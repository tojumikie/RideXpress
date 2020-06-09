using System;

namespace DataTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int onlineUsers;
            onlineUsers = 2;
            i = 50;

            double d = 1.5;
            double accountBalance = 120.35;
            d = 50.6;

            char c = 'a';
            char dollar = '$';
         
            string s = "hello world";
            string welcomeMessage = "Welcome to the data types demo.";
            string emptyString = "";
            string oneCharacter = "a";

            bool b = true;
            bool activeBankAccount = false;
            activeBankAccount = b;

            Console.Out.WriteLine(welcomeMessage);
            Console.Out.WriteLine();
            Console.Out.Write("Account active: ");
            Console.Out.WriteLine(activeBankAccount);
            Console.Out.Write("Account Balance: ");
            Console.Out.Write(dollar);
            Console.Out.WriteLine(accountBalance);
            Console.Out.WriteLine();
            Console.Out.WriteLine("Press enter to continue...");
            Console.In.ReadLine();
        }
    }
}
