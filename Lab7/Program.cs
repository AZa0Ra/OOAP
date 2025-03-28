using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    // Command
    interface ICommand
    {
        void Execute(Order order);
    }

    class AddOrderCommand : ICommand
    {
        Random random = new Random();
        public void Execute(Order order)
        {
            var rand = random.Next(10);
            order.orderList.Add($"Бургер {rand}");
            Console.WriteLine($"Додано до замовлення Бургер {rand}");
        }
    }

    class RemoveOrderCommand : ICommand
    {
        public void Execute(Order order)
        {
            if (order.orderList.Count > 0)
            {
                Console.WriteLine($"Видалено з замовлення Бургер {order.orderList[order.orderList.Count - 1]}");
                order.orderList.RemoveAt(order.orderList.Count - 1);
            }
        }
    }

    class Order
    {
        public List<string> orderList = new List<string>();
    }

    // Chain Responsobility
    abstract class CommandHandler 
    {
        protected CommandHandler next;
        public void SetNext(CommandHandler handler) => next = handler;

        public virtual void Handle(ICommand command, Order order)
        {
            next?.Handle(command, order);
        }
    }

    class OrderLimitHandler : CommandHandler
    {
        public override void Handle(ICommand command, Order order)
        {
            if (command is AddOrderCommand && order.orderList.Count >= 5)
            {
                Console.WriteLine("\n[Handler] Не можна додати більше 5 замовлень!");
                return;
            }

            if (command is RemoveOrderCommand && order.orderList.Count == 0)
            {
                Console.WriteLine("\n[Handler] Не можна видалити, бо замовлень немає!");
                return;
            }

            base.Handle(command, order);
        }
    }
    class LoggingHandler : CommandHandler
    {
        public override void Handle(ICommand command, Order order)
        {
            Console.WriteLine("\n[Handler] Логування команди...");
            command.Execute(order);
            base.Handle(command, order);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Order order = new Order();
            ICommand addOrder = new AddOrderCommand();
            ICommand removeOrder = new RemoveOrderCommand();

            CommandHandler orderLimitHandler = new OrderLimitHandler();
            CommandHandler logger = new LoggingHandler();

            orderLimitHandler.SetNext(logger);

            while (true)
            {
                Console.WriteLine("\n[Меню]");
                Console.WriteLine("1. Додати бургер");
                Console.WriteLine("2. Видалити бургер");
                Console.WriteLine("3. Завершити та вивести замовлення");
                Console.Write("Оберіть дію: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        orderLimitHandler.Handle(addOrder, order);
                        break;
                    case "2":
                        orderLimitHandler.Handle(removeOrder, order);
                        break;
                    case "3":
                        Console.WriteLine("\n[Ваше замовлення]");
                        if (order.orderList.Count == 0)
                        {
                            Console.WriteLine("Порожнє");
                        }
                        else
                        {
                            foreach (var item in order.orderList)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        return;
                    default:
                        Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                        break;
                }
            }
        }
    }
}
