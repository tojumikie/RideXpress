using System;
using Operators;

namespace Example1
{
    class Example1
    {
        static void Main(string[] args)
        {
            //int count = 3;
            //count = count + 2; // count = 5
            //count += 2; // count = 7

            //Console.Out.WriteLine("count++: " + count++); //print count, then increment by 1 (to 8)
            //Console.Out.WriteLine("++count:" + ++count);

            //Robot robotOne = new Robot();
            //robotOne.maxSpeed = 10;
            //robotOne.type = "Vacuum";

            //Robot robotTwo = new Robot();
            //robotTwo.maxSpeed = 10;
            //robotTwo.type = "Vacuum";

            //Console.Out.WriteLine("robotOne == robotTwo: " + (robotOne == robotTwo));
            //Console.Out.WriteLine("robotOne.Equals(robotTwo): " + (robotOne.Equals(robotTwo)));
            //Console.Out.WriteLine();

            int x = 2;
            int y = 3;

            Console.Out.WriteLine("X > Y: " + (x > y));
            Console.Out.WriteLine("(X > Y) || (X == Y): " + ((x > y) || (x == y)));
            Console.Out.WriteLine("(X < Y) && (Y == 3): " + ((x < y) && (y == 3)));
        }
    }
}
