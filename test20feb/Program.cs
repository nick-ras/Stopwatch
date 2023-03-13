// See https://aka.ms/new-console-template for more information
using System;

namespace stopwatch;


/* created a stopwatch class with methods that can be used to start and stop the watch and return the time that has elapse
*/
class StopWatch
{
    private DateTime StartPressed;
    private DateTime TotalTime;

    public void Start()    {
        StartPressed = DateTime.Now;
    }

    public void StopTheWatch()    {
        TotalTime += DateTime.Now - StartPressed;
    }
    public DateTime Total()
    {
        return TotalTime;
    }
}

class Program
{
    static void Main(string[] args)    {
        var watch = new StopWatch();
				System.Console.WriteLine("Press any key to start the watch");
				Console.ReadKey();
        watch.Start();
				System.Console.WriteLine("Press any key to stop the watch");
				Console.ReadKey();
        watch.StopTheWatch();
        Console.WriteLine("Time in milliseconds: {0}\n", watch.Total().Millisecond);
    }
}