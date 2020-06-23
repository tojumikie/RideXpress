using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractClasses
{
    abstract class Robot
    {
        private int maxSpeed;
        private string robotType;

        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }
        public string RobotType
        {
            get { return robotType; }
            set { robotType = value; }
        }

        public abstract void Move();

        public void Identify()
        {
            Console.Out.WriteLine("I'm a " + robotType + " robot.");
        }
    }
}
