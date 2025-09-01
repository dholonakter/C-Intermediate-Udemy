using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class StopWatch
    {
        private bool _isStopWatchRunning = false;
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; private set; }


        public void Start()
        {


            if (_isStopWatchRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running.");
            }
            StartTime = DateTime.Now;

            Console.WriteLine("StartWatch started at: " + StartTime.ToString("mm:ss.fff"));
            _isStopWatchRunning = true;



        }
        public void Stop()
        {

            if (!_isStopWatchRunning)
            {
                throw new InvalidOperationException("Stopwatch has not been started.");
            }

            StopTime = DateTime.Now;
            Console.WriteLine("StartWatch started at: " + StopTime.ToString("mm:ss.fff"));
            _isStopWatchRunning = false;


        }
        public TimeSpan Duration()
        {
            var timeSpan = StopTime - StartTime;
            Console.WriteLine("Duration " + timeSpan);
            return timeSpan;

        }
    }
}
