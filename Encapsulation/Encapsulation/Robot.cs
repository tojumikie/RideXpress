using System;
using System.Security.Cryptography.X509Certificates;

namespace Encapsulation
{
    class Robot
    {
        public int speed;
        private string robotType;
        static void Main(string[] args)
        {
            
        }
        public string RobotType
        {
            get { return robotType; }
            set
            {
                if (value == null)
                {
                    robotType = "";
                }
                else
                {
                    robotType = value;
                }
            }
        }
    }
}
