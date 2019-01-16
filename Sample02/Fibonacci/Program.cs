using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in Fibonacci().Take(20))
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }


        private static IEnumerable<int> Fibonacci()
        {
            int current = 1, next = 1;
            while (true)
            {
                yield return current;
                next = current + (current = next);
            }
        }
    }
}
