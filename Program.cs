using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, x, y;
            Console.Write("Enter the height of the triangle: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (y = 1; y <= num; y++)
            {
                for (x = 1; x <= y; x++)
                {
                    Console.Write("* ");
                }
                for (x = y + 1; x <= num; x++)
                {
                    Console.Write("_ ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }






    }
}
