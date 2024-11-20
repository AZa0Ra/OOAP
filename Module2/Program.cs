using System;
using System.Text;

namespace Module2
{
    public abstract class Employee
    {
        protected IPaymentMethod paymentMethod;

        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position, IPaymentMethod paymentMethod)
        {
            Name = name;
            Position = position;
            this.paymentMethod = paymentMethod;
        }
        public abstract void CalculateSalary();
    }

    public interface IPaymentMethod
    {
        double CalculateSalary(Employee employee);
    }

    public class HourlyPayment : IPaymentMethod
    {
        private double hourlyRate;

        public HourlyPayment(double hourlyRate)
        {
            this.hourlyRate = hourlyRate;
        }

        public double CalculateSalary(Employee employee)
        {
            double hoursWorked = 160;
            return hoursWorked * hourlyRate;
        }
    }

    public class PieceworkPayment : IPaymentMethod
    {
        private double paymentPerItem;

        public PieceworkPayment(double paymentPerItem)
        {
            this.paymentPerItem = paymentPerItem;
        }

        public double CalculateSalary(Employee employee)
        {
            int itemsCompleted = 100;
            return itemsCompleted * paymentPerItem;
        }
    }

    public class Manager : Employee
    {
        public Manager(string name, string position, IPaymentMethod paymentMethod)
            : base(name, position, paymentMethod) { }

        public override void CalculateSalary()
        {
            double salary = paymentMethod.CalculateSalary(this);
            Console.WriteLine($"{Name}'s ({Position}) salary: {salary}");
        }
    }

    public class Worker : Employee
    {
        public Worker(string name, string position, IPaymentMethod paymentMethod)
            : base(name, position, paymentMethod) { }

        public override void CalculateSalary()
        {
            double salary = paymentMethod.CalculateSalary(this);
            Console.WriteLine($"{Name}'s ({Position}) salary: {salary}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentMethod hourlyPayment = new HourlyPayment(20);
            IPaymentMethod pieceworkPayment = new PieceworkPayment(10);

            Employee manager = new Manager("Ivan", "Manager", hourlyPayment);
            Employee worker = new Worker("Taras", "Employee", pieceworkPayment);

            manager.CalculateSalary();
            worker.CalculateSalary();
        }
    }
}
