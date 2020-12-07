using System;
using System.Threading;

namespace Lesson21Homework
{
    class Program
    {

        static void Factorial(int number)
        {
            if (number==0)
            {
                Console.WriteLine("Factorial 0!=1");
            }
            else
            {
                Thread t = new Thread(() => Factorial(number)); 
                t.Start(number-1);
            }
        }
        static void Main(string[] args)
        {
            Factorial(5);
        }
    }
}
