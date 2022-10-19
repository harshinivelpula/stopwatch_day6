



using System.Diagnostics;

class Program
{
    static void Main()
    {

        var stopwatch = new Stopwatch();

        stopwatch.Start();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("HI");
        }

        stopwatch.Stop();
        Console.WriteLine("Time Elapsed : {0}",
            stopwatch.Elapsed);
        Console.ReadLine();
    }
}