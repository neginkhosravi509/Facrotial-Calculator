using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoril
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 0; count <7; count++)
            {
                Console.WriteLine("enter number");
                int num = int.Parse(Console.ReadLine());
                long fact = Factoril(num);
                Console.WriteLine($"factorial {num} = {fact}\n");
            }
            Console.ReadKey();
        }
        static long Factoril(int n)
        {
            long result = 1;
            for (int i = 2; i <=n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
