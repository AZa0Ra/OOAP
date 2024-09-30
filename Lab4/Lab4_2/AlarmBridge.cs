using System;

namespace Lab4_2
{
    public interface IAlarmC
    {
        void Start();
        void Stop();
    }
    public abstract class AlarmClmpl
    {
        protected IAlarmC Alarm;

        protected AlarmClmpl(IAlarmC alarm)
        {
            Alarm = alarm;
        }

        public abstract void Ring();
        public abstract void Notify();
        public void ToWake()
        {
            Ring();
            Notify();
        }
    }
    //Ex. Can be created silent alarm by realizing interface IAlarmC
    public class AlarmBridge : IAlarmC
    {
        public void Start()
        {
            Console.WriteLine("Alarm started");
        }

        public void Stop()
        {
            Console.WriteLine("Alarm stopped");
        }
    }

}
