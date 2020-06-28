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
            Console.Out.WriteLine("\"Quotes\" must be \"escaped\" to avoid confusing the CLR");
            Console.Out.WriteLine(@"Please stay out of C:\Windows\System32");
            Console.In.ReadLine();
            #endregion

            #region StringFormatting
            String robot = "hover bot";
            int speed = 11;
            String str = String.Format("The {0} is traveling at {1:N1} mph, going at {2:P1} of its " +
                "max speed", robot, speed, speed / 100.0);
            Console.Out.WriteLine(str);
            Console.In.ReadLine();
            #endregion

            #region StringManipulation
            String typo = "rbto";
            typo = typo.Insert(1, "o");
            typo = typo.Insert(3, "o");
            typo = typo.Remove(typo.Length - 1);
            Console.Out.WriteLine("Edited typo: " + typo);
            Console.In.ReadLine();

            Console.Out.WriteLine("Robot starts with \"first\": " + typo.StartsWith("first"));
            Console.Out.WriteLine("Robot ends with \"ot\": " + typo.EndsWith("ot"));
            Console.In.ReadLine();

            Console.Out.WriteLine("Substring: " + typo.Substring(2));
            Console.In.ReadLine();

            Console.Out.WriteLine("\"Robot\" contains \"o\": " + typo.Contains("o"));
            typo = typo.Replace("o", "i");
            Console.Out.WriteLine("Not anymore, it doesn't! " + typo);
            Console.In.ReadLine();

            String spaceDelimitedString = "This is a space-delimited string, by which I mean a sentence.";
            String[] stringArray = spaceDelimitedString.Split(new char[] { ' ' });
            foreach (String s in stringArray)
            {
                Console.Out.Write(s + "-");
            }
            Console.Out.WriteLine();
            #endregion
        }
    }
}
