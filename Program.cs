using System;

namespace HW2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Learning about simple classes in SE450 is fun!");
            Console.WriteLine();
            Players players = new Players(); // instantiate players class

            players.InitializeList();
            players.PrintList();

            Console.WriteLine();
            Console.WriteLine("We are now finding the maximum weight..");
            players.FindMaxWeight(); // display the heaviest node

            Console.WriteLine();
            Console.WriteLine("We are now finding the node with the minimum weight..");
            players.FindMinWeight();// display the lightest node

            Console.WriteLine();
            Console.WriteLine("Thank-you and have a nice day :-)");
            Console.WriteLine();
            Console.Write("Please press any key to exit..");
            Console.ReadKey();
        }
    }
}
