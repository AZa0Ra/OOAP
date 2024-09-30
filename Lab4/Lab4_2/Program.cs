using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alarm alarm = new Alarm(new AlarmBridge());
            alarm.ToWake();
        }
    }

    public class Alarm : AlarmClmpl
    {
        public Alarm(IAlarmC alarm) : base(alarm) { }
        public override void Ring()
        {
            Console.WriteLine("Alarm ringing.");
            Alarm.Start();
        }
        public override void Notify()
        {
            Console.WriteLine("Alarm notifying.");
            Alarm.Stop();
        }

    }
}
