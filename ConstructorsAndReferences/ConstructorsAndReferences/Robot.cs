using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsAndReferences
{
    class Robot
    {
        private int maxSpeed;
        private String robotType;

        public Robot(int maxSpeed, String robotType)
        {
            this.maxSpeed = maxSpeed;
            this.robotType = robotType;
        }

        public int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value < 0)
                    maxSpeed = 0;
                else
                    maxSpeed = value;
            }
        }
        public String RobotType
        {
            get { return robotType; }
            set
            {
                if (value == null)
                    robotType = "";
                else
                    robotType = value;
            }
        }
    }
}
