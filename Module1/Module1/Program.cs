using System;

namespace Module1
{
    public class Client
    {
        private IPhone _phone;
        private IDeliveryInfo _deliveryInfo;

        public Client(IPhoneFactory factory)
        {
            _phone = factory.CreatePhone();
            _deliveryInfo = factory.CreateDeliveryInfo();
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine($"Phone model: {_phone.GetModel()}");
            Console.WriteLine($"Price: {_phone.GetPrice()} USD");
            Console.WriteLine($"Delivery: {_deliveryInfo.GetDeliveryTime()}");
            Console.WriteLine($"Shipping cost: {_deliveryInfo.GetDeliveryCost()} USD");
        }
    }

    public class Program
    {

        private static int GetCountryChoice()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Select the country of manufacture (1 - USA, 2 - East): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out choice) && (choice == 1 || choice == 2))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter 1 or 2.");
                }
            }
            return choice;
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice = GetCountryChoice();

            IPhoneFactory factory;
            if (choice == 1)
            {
                factory = new USPhoneFactory();
            }
            else
            {
                factory = new EasternPhoneFactory();
            }

            Client client = new Client(factory);
            client.DisplayOrderDetails();

            Do ob = new Do();
            ob.DoElse<String>("3");


        }

    }
}
