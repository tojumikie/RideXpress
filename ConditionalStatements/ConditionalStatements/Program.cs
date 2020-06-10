using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 3;

            //if (x <= 5)
            //{
            //    Console.Out.WriteLine("X is 5!");
            //}
            //else if (x == 6)
            //{
            //    Console.Out.WriteLine("X is 6!");
            //}
            //else
            //{
            //    Console.Out.WriteLine("X isn't 5, it's " + x + "!");
            //}
            int menu = 0;
            Console.Out.WriteLine("Please select an Option (1 or 2):");
            menu = Convert.ToInt32(Console.In.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.Out.WriteLine("You have selected option 1!");
                    break;
                case 2:
                    Console.Out.WriteLine("You have selected option 2!");
                    break;
                default:
                    Console.Out.WriteLine("Invalid selection.");
                    break;
            }
        }
    }
}
