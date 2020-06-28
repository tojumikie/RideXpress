using System;

namespace ConstructorsAndReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            //object obj;
            //int intsAreObjectsToo = 10;
            //intsAreObjectsToo.ToString();
            //Int32 thisIsAnIntToo = 5;

            Robot myRobot = new Robot(10, "Hover Bot");
            //Robot otherRobot = new Robot();

            Console.Out.WriteLine("Max Speed: " + myRobot.MaxSpeed);
            Console.Out.WriteLine("Robot Type: " + myRobot.MaxSpeed);
        }
    }
}
