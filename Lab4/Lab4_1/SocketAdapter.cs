using System;
using System.Threading;
using Lab4_1;

namespace Lab4_1_Socket
{
    public class SocketAdapter : ISocketAdapter
    {
        private readonly OldVagonSystem _oldVagonSystem;

        public SocketAdapter(OldVagonSystem oldVagonSystem)
        {
            _oldVagonSystem = oldVagonSystem;
        }

        public void Charge()
        {
            _oldVagonSystem.ThinSocket();
            Console.WriteLine("Using adapter to charge.\nCharging.");
            Thread.Sleep(2000);
            Console.WriteLine("Charging..");
            Thread.Sleep(2000);
            Console.WriteLine("Charging...");
            Thread.Sleep(4000);
            Console.WriteLine("\nDone");
        }
    }
    public interface ISocketAdapter
    {
        void Charge();
    }
}
