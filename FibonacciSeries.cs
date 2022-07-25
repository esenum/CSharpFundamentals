using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class FibonacciSeries
    {

        //The Fibonacci numbers are the numbers in the following integer sequence.
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144,233,377 ...
        //In mathematical terms, the sequence Fn of Fibonacci numbers is defined by the recurrence relation
        //F(n) = F(n - 1) + F(n - 2)        
        //i.e:F(4) = F(3) + F(2) =>  3=2+1
        //i.e:F(6) = F(5) + F(4) =>  8=5+3

        //METHOD1


        public static void Main()
        {
            int a= 0;
            int b= 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i=1;i<=12;i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }

        //METHOD2

        //write to the console F(n) value, i.e= F(12)=377

        public static int Fib(int n)
        {
            if(n<=1)
            {
                return n;
            }
            else
            {
                return Fib(n-1)+Fib(n-2);
            }
        }

        public static void Main2()
        {
            int n = 12;
            Console.WriteLine(Fib(n));
        }
    }
}
