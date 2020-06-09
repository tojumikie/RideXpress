using System;

namespace Operators
{
    class Example1
    {
        static void Main(string[] args)
        {
            int count = 3;
            count = count + 2; // count = 5
            count += 2; // count = 7

            Console.Out.WriteLine("count++: " + count++); //print count, then increment by 1 (to 8)
            Console.Out.WriteLine("++count:" + ++count);
        }
    }
}
