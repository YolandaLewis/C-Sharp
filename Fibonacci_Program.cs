 using System;

namespace Fibonacci_ConsoleApp
{
    class Program
    {
        public static int CalculateFibonacci(int i)
        {
            int n = i - 1;  //decrement fibonacci number to be calculated by one to obtain starting number
            
            // create an array to store fibonacci numbers. The first and second indexes will be 0 and 1
            int[] fibonacci_store = new int[n + 1];
            fibonacci_store[0] = 0;
            fibonacci_store[1] = 1;

            //loop over numbers to use the previous and the most current value in the array to calculate the next fibonacci number
            for (i=2; i<=n; i++)
            {
                fibonacci_store[i] = fibonacci_store[i - 2] + fibonacci_store[i - 1];
            }
            //return the calculated fibonacci number
            return fibonacci_store[n];

        }
        static void Main(string[] args)
        {
            int Number1 = CalculateFibonacci(15); // Calculate Fibonacci number 15
            int Number2 = CalculateFibonacci(22); // Calculate Fibonacci number 22

            Console.WriteLine("The 15th Fibonacci Number is " + Number1); // display fibonacci number
            Console.WriteLine("The 22nd Fibonacci Number is: " + Number2); // display fibonacci number
            Console.WriteLine();
            Console.WriteLine("Fibonacci Sequence up to Fibonacci number 22 now printing..");
            Console.WriteLine();

            for(int i =2; i< 24; i++)
            {
                Console.WriteLine("Fibonacci Number {0} = {1}", i, CalculateFibonacci(i));
            }
            Console.WriteLine();
            Console.WriteLine("Have A nice Day!");
            Console.Write("Press any Key to exit.. ");
            Console.ReadKey();

        }
    }
}
