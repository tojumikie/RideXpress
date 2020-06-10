using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    class Robot
    {
        public String type; //The type of a robot
        public int maxSpeed; //How fast the robot can move in units

        public override bool Equals(object obj)
        {
            //if the passed-in object-type reference does not point to a Robot object,
            //then that memory object cannot possible be equivalent to this robot.
            if(!(obj is Robot))
            {
                return false;
            }
            Robot otherRobot = (Robot)obj;

            //Robots are the same if their type is the same. The type is a string,
            //so we use a string's Equals method to compare them
            if (this.type.Equals(otherRobot.type))
                return true;
            else
                return false;
        }
    }
}
