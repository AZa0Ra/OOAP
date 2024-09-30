using System;
using Lab4_1_Socket;

namespace Lab4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewVagonSystem newVagonSystem = new NewVagonSystem();
            newVagonSystem.MatchSocket();

            OldVagonSystem oldVagonSystem = new OldVagonSystem();
            oldVagonSystem.ThinSocket();

            SocketAdapter socketAdapter = new SocketAdapter(oldVagonSystem);
            socketAdapter.Charge();
        }
    }
    public class NewVagonSystem
    {
        public void MatchSocket()
        {
            Console.WriteLine("Socket is matching. Can charge\n");
        }
    }
    public class OldVagonSystem
    {
        public void ThinSocket()
        {
            Console.WriteLine("Socket is thin. Can't charge\n");
        }
    }
}
