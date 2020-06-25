using System;
using System.Collections.Generic;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> contacts = new Dictionary<string, string>();

            contacts.Add("James", "123-456-7890");
            contacts.Add("GT", "805-867-5309");
            contacts.Add("Aron", "703-333-1234");

            if (contacts.ContainsKey("Aron"))
            {
                contacts.Remove("Aron");
            }
            Console.Out.WriteLine(contacts["James"]);
            String output;
            if (contacts.ContainsKey("GT"))
            {
                contacts.TryGetValue("GT", out output);
                if (output != null)
                {
                    Console.Out.WriteLine(output);
                }
            }

            Console.Out.WriteLine("\n");

            foreach (String value in contacts.Values)
            {
                Console.Out.WriteLine(value);
            }
        }
    }
}
