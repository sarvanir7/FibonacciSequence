using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Fibonacci
{
    class FibonacciSeries
    {
        public static int Fibonacci(int n)
        {
            int n1 = 0, n2 = 1, result = 0;
            if (n == 0) return 0;      // return the first number of the series
            if (n == 1) return 1;       //  return  the second number of the series
            for (int i = 2; i <= n; i++)      // main process starts from here
            {
                result = n1 + n2;
                n1 = n2;
                n2 = result;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }
            Console.ReadKey();
        }
    }
}
