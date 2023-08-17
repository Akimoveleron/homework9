using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    internal class SumArray
    {

        public static long Sum(int[] array) 
        {
           long sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            Console.WriteLine($"Method Sum {sum}");
            return sum;
        }

      

        public static long SumParallel(int[] array)
        {
            long sum = 0;
            Parallel.For(0, array.Length, new ParallelOptions()
            {
                MaxDegreeOfParallelism = 4
            }, i => {
              
                Interlocked.Add(ref sum, array[i]);

            });
            Console.WriteLine($"Method SumParallel {sum}");
            return sum;
        }
        public static long SumPLINQ(int[] array)
        {
            long sum = array.AsParallel().Sum();
            Console.WriteLine($"SumPLINQ {sum}");
            return sum;
        }
        
    }
}
