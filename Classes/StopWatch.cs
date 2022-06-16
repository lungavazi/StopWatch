using System;
using System.Threading;

namespace Classes
{
    public class StopWatch
    {
        private DateTime? _startTime;
        private DateTime? _endTime;

        public void Start()
        {
            try
            {

                if (_startTime != null && _endTime == null)
                    throw new InvalidOperationException("Please stop the stopwatch.");

                _startTime = DateTime.Now;
                //delay stopwatch
                Thread.Sleep(10000);
            }
            catch (Exception)
            {
                throw new Exception("An error occurred while starting Stopwatch.");
            }
        }
        public void Stop()
        {
            try
            {
                _endTime = DateTime.Now;
                Console.WriteLine($"The duration between start time: {_startTime} and stop time:{_endTime} is {_endTime - _startTime}");
            }
            catch (Exception)
            {
                throw new Exception("error occurred while starting Stopwatch");
            }
            _endTime = null;
            _startTime = null;
        }
    }
}
