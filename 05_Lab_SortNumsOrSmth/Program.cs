using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Lab_SortNumsOrSmth
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var results = new List<int>();
            foreach (var num in nums)
            {
                if (ExactSquare(num))
                {
                    results.Add(num);
                }
            }

            results.Sort();
            results.Reverse();
            Console.WriteLine(String.Join(" ",results));

        }

         static bool ExactSquare(int num)
         {
             var sqrt = (int) Math.Sqrt(num);
             return (sqrt*sqrt == num);
         }
    }
}
