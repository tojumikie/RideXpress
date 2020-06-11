using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int count = 1; count < 6; ++count)
            //{
            //    Console.Out.WriteLine("count is " + count);
            //}

            //int count = 35;

            //do
            //{
            //    Console.Out.WriteLine("Count is " + count);
            //    ++count;
            //} while (count < 6);

            int[] arr = { 1, 3, 5 };

            foreach (int i in arr)
            {
                Console.Out.WriteLine(i + " ");
            }
        }
    }
}
