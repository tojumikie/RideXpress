using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractClasses
{
    class HoverBot : Robot, IScanning
    {
        public HoverBot(int maxSpeed)
        {
            this.RobotType = "hovering";
            this.MaxSpeed = maxSpeed;
        }

        public override void Move()
        {
            Console.Out.WriteLine("The " + RobotType + " robot flies " + MaxSpeed + " units.");
        }

        public void Scan(String target)
        {
            Console.Out.WriteLine("The robot scans for " + target);
        }
    }
}
