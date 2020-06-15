using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class EncapsulationDemo
    {
        public void Main(string[] args)
        {
            Robot myRobot = new Robot();
            myRobot.speed = 10;
            myRobot.RobotType = "Vacuum";
        }
    }
}
