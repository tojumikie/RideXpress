using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Robot
    {
        // a field or variable
        private string robotType = "hover bot";

        // a method
        public void Introduction()
        {
            Console.WriteLine("I'm a {0} type of robot.", robotType);
        }
    }
}
