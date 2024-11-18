using System;
using System.Diagnostics;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        Console.WriteLine("Starting multi-threaded computation...");
        
        int numberOfTasks = 10; //1 - однопоточный
        Task[] tasks = new Task[numberOfTasks];

        Stopwatch stopwatch = Stopwatch.StartNew();

        for (int i = 0; i < numberOfTasks; i++)
        {
            int taskNumber = i;
            tasks[i] = Task.Run(() => PerformComputation(taskNumber));
        }

        // Ждем завершения всех задач

        Task.WaitAll(tasks);
        
        Console.WriteLine("All tasks completed.");

        stopwatch.Stop();

        Console.WriteLine($"PerformComputation: {stopwatch.ElapsedMilliseconds} ms");
        
        
    }

    static void PerformComputation(int taskNumber)
    {
        double result = 0;

        // Выполнение ресурсоемкой операции
        for (int i = 0; i < 1_000_000; i++)
        {
            result += Math.Sqrt(i * taskNumber) * Math.Sin(i);
        }

        Console.WriteLine($"Task {taskNumber} completed with result {result}");
    }
}
