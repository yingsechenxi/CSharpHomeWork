using System;

namespace Timer
{
    public delegate void TickHandler(int time);
    public delegate void AlarmHandler(int time);
    public class Clock
    {
        public event TickHandler OnTick;
        public event AlarmHandler OnAlarm;
        public void Tick(int time)
        {
            OnTick(time);
        }
        public void Alarm(int time)
        {
            OnAlarm(time);
        }
    }
    public class TickandAlarm
    {
        public Clock clock1 = new Clock();
        public int tickTock;
        public TickandAlarm()
        {
            tickTock = 0;
            clock1.OnTick += new TickHandler(Clock_OnTick);
            clock1.OnAlarm += new AlarmHandler(Clock_OnAlarm);
            void Clock_OnTick(int tickTock)
            {
                Console.WriteLine("Clock ticks at " + tickTock);
            }
            void Clock_OnAlarm(int tickTock)
            {
                Console.WriteLine("Clock alarms at " + tickTock);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TickandAlarm testClock = new TickandAlarm();
            for(int i=1;i<=10;i++)
            {
                testClock.tickTock = i;
                //testClock.clock1.Tick(i);
                //testClock.clock1.Alarm(i);
            }
        }
    }
}
