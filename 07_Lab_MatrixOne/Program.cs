using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Lab_MatrixOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            var matrix = new char[rows][];
            var letter = 'A';

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols];
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = letter;
                    letter++;
                }
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }

        }
    }
}
