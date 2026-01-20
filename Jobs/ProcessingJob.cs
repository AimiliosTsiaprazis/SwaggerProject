using System;
using Hangfire;
using Hangfire.MemoryStorage;

public class ProcessingJob
{
    /// A job that simply prints a line to the console when it runs.
    public async Task ConsoleVerification()
    {
        System.Console.WriteLine("Hangfire Processing Job is working!");
    }
    public async Task DeveloperVerification()
    {
        string name = "Aimilios Tsiaprazis";
        int age = 23;
        string email = "a...t...@gmail.com";
        string job = "Software Developer";
        System.Console.WriteLine(name);
        System.Console.WriteLine(age);
        System.Console.WriteLine(email);
        System.Console.WriteLine(job);
    }
}
