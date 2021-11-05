using System;
using System.Threading;

namespace StopWatchExercise
{
    public class StopWatch
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        private bool runing = false;
        public void Start(DateTime start)
        {
            if (!runing)
            {
                StartTime = start;
                runing = true;
            }
            else
            {
                throw new InvalidOperationException("StopWatch is already runing!");
            }
        }
        public void Stop(DateTime stop)
        {
            if (runing)
            {
                EndTime = stop;
                runing = false;
            }
        }
        public TimeSpan GetInterval()
        {
            var duration = EndTime - StartTime;
            return duration;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            //stopWatch.StartTime = DateTime.Now;
            //stopWatch.EndTime = DateTime.Now.AddDays(1);
            for (int i = 0; i < 2; i++)
            {
                stopWatch.Start(DateTime.Now);
                Thread.Sleep(1000);
                stopWatch.Stop(DateTime.Now.AddDays(1));
                Console.WriteLine(stopWatch.GetInterval().ToString());
                Console.ReadLine();
            }
        }
    }
}
