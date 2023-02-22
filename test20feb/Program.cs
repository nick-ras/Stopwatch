﻿// See https://aka.ms/new-console-template for more information
using Amazon1;
using System;

namespace stopwatch;


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
        watch.Start();
        Thread.Sleep(2000);
        watch.StopTheWatch();
        watch.Start();
        Thread.Sleep(1000);
        watch.StopTheWatch();
        Console.WriteLine("(F) Full date/long time: {0}\n", watch.Total().Second);
    }
}