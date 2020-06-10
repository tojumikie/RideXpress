using System;

namespace SwitchStatementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please choose robot by movement type (1) with legs, (2) on wheels, or (3) flyer: ");
            String robotType = Console.ReadLine();

            //switch statement
            //switch (robotType)
            //{
            //    //robot with legs
            //    case "1":
            //        Console.WriteLine("The robot has ran so fast; you can't keep up.");
            //        break;
            //    //robot with wheels
            //    case "2":
            //        Console.WriteLine("The robot has driven off into the sunset without you.");
            //        break;
            //    //robot with wings
            //    case "3":
            //        Console.WriteLine("The robot has flown up into the atmosphere, goodbye.");
            //        break;
            //    //error message
            //    default:
            //        Console.WriteLine(robotType + " is an invalid option.");
            //        break;
            //}

            //switch statement 2
            switch (robotType)
            {
                //2 cases for the same robot type
                case "1": case "2":
                    Console.WriteLine("The robot has driven off into the sunset without you.");
                    break;
                //chained cases
                case "3":
                    Console.WriteLine("The robot has flown up into the atmosphere, goodbye.");
                    goto case "4";
                case "4":
                    Console.WriteLine("Case 4: the robot has returned.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
    }
}
