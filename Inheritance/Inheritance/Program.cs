using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot1 = new Robot();
            HoverBot robot2 = new HoverBot(10);

            robot1.Travel();
            robot2.Travel();
        }
    }
}
