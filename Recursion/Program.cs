using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
     
        Stopwatch stopwatch = Stopwatch.StartNew();
        int result = ReyRom.Recursion.Fibonacci(40);
        stopwatch.Stop();
        Console.WriteLine($"Fibonacci(40) = {result}");
        Console.WriteLine($"Fibonacci(40): {stopwatch.ElapsedMilliseconds} ms");


        stopwatch.Restart();
        result = ReyRom.Recursion.SumNaturalNumbers(1000);
        stopwatch.Stop();
        Console.WriteLine($"SumNaturalNumbers(40) = {result}");
        Console.WriteLine($"SumNaturalNumbers(40): {stopwatch.ElapsedMilliseconds} ms");
    }
}
