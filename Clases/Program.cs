using System;

namespace Classes
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            stopWatch.Start();
            stopWatch.Stop();
            Console.ReadKey();
        }
    }
}
