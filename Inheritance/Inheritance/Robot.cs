using System;

namespace Inheritance
{
    class Robot
    {
        protected int maxSpeed;
        protected string robotType;

        public Robot()
        {
            this.maxSpeed = 1;
            this.robotType = "Generic";
        }

        public virtual void Travel()
        {
            Console.Out.WriteLine("The " + robotType + " robot moves " + maxSpeed + " units.");
        }
    }
}
