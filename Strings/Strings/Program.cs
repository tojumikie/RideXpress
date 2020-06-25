using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EmptyOrNull
            String nullString = null;
            String emptyString = "";

            Console.Out.WriteLine("nullString is null or empty: " + String.IsNullOrEmpty(nullString));
            Console.Out.WriteLine("emptyString is null or empty: " + String.IsNullOrEmpty(emptyString));
            #endregion

            #region Escape Characters
            Console.Out.WriteLine("Use of the \\\\ escape character: \\");
            Console.Out.WriteLine("Use of the \\n escape character: \nNew line");
            Console.Out.WriteLine("Use of the \\t escape character:\t\t\t 3-Tabbed line");
            Console.Out.WriteLine("\Quotes\" must be \"escaped\" to avoid confusing the CLR");
            Console.In.ReadLine();
            #endregion
        }
    }
}
