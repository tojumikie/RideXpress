using System;
using System.Collections.Generic;
using System.Globalization;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a prepopulated array of size 3
            //for an uninitialized array of size 3, you would type
            //"String[] sArray = new String[3]"
            String[] sArray = { "This ", "is an ", "array!" };
            //This is an uninitialized list.
            List<string> sList = new List<string>();

            sList.Add("This ");
            sList.Add("is a ");
            sList.Add("List!");

            for (int i = 0; i < sArray.Length; ++i)
            {
                Console.Out.Write(sArray[i]);
            }
            Console.Out.Write("\n");

            foreach (string s in sList)
            {
                Console.Out.Write(s);
            }
            Console.Out.WriteLine("\n");

            /* ---------------------------------- */

            sList.Insert(1, "container ");
            foreach(string s in sList)
            {
                Console.Out.Write(s);
            }
            Console.Out.WriteLine("\n");

            /* ---------------------------------- */

            int[,] table = new int[10, 10];

            //for each element in the first array dimension...
            for (int i = 1; i < table.GetLength(0); ++i)
            {
                //iterate over each element in the second array dimension
                for (int j = 1; j <= table.GetLength(1); ++j)
                {
                    //array indices start at 0 in C#
                    table[i - 1, j - 1] = i * j;
                    Console.Out.Write(table[i - 1, j - 1] + " ");
                }
                Console.Out.WriteLine();
            }
        }
    }
}
