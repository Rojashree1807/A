using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppAss4ps3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("First 10 Numbers in Fibonacci Sequence:");
            int n = 10;
            int[] fibonacci = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                {
                    fibonacci[i] = i;
                }
                else
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }

                Console.Write($"{fibonacci[i]} ");
            }

            Console.ReadLine(); 

        }
    }
}
