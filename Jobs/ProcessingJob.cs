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
        string name = "Max Mustermann";
        int age = 00;
        string email = "maxmustermann@gmail.com";
        string job = "Software Developer";
        System.Console.WriteLine(name);
        System.Console.WriteLine(age);
        System.Console.WriteLine(email);
        System.Console.WriteLine(job);
    }
}
