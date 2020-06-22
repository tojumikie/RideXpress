using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class HoverBot : Robot
    {
        private string purpose = "get camera footage of the area";

        public HoverBot(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
            this.robotType = "Hover Bot";
        }

        public override void Travel()
        {
            Console.Out.WriteLine("The " + robotType + " robot flies " + maxSpeed + " units to " + purpose);
        }
    }
}
