using System;

namespace InterfacesAndAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            HoverBot hovBot = new HoverBot(5);

            hovBot.Identify();
            hovBot.Move();
            hovBot.Scan("scanning the street");

            IScanning scanner = new HoverBot(10);
            scanner.Scan("found trash on the street");
        }
    }
}
