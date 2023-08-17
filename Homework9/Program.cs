// See https://aka.ms/new-console-template for more information
using Homework9;
using System.Diagnostics;


List<int> lengthOfArray = new List<int> { 100_000, 1000_000, 10_000_000 };

foreach (int length in lengthOfArray)
{
    var numbers = Enumerable.Range(0, length).
        Select(_ => Random.Shared.Next(0, 100)).ToArray();
    Console.WriteLine($"Array containing {length} elements has created");


    {
        var sw = Stopwatch.StartNew();
        SumArray.Sum(numbers);
        Console.WriteLine("Time is   " + sw.ElapsedMilliseconds);
    }

    {
        var sw = Stopwatch.StartNew();
        SumArray.SumParallel(numbers);
        Console.WriteLine("Time is   " + sw.ElapsedMilliseconds);
    }
    {
        var sw = Stopwatch.StartNew();
        SumArray.SumPLINQ(numbers);
        Console.WriteLine("Time is   " + sw.ElapsedMilliseconds);
    }
    Console.WriteLine(  );
}


