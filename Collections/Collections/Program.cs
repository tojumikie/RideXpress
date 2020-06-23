using System;
using System.Collections.Generic;

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
            Console.Out.Write(s);

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
        }
    }
}
