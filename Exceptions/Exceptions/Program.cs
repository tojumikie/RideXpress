using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int zero = 0;
            try
            {
                int a = 1 / zero;
            }
            catch (ArithmeticException e)
            {
                Console.Out.WriteLine("You can't divide by zero!");
                Console.Out.WriteLine(e.StackTrace);
            }
            catch (StackOverflowException)
            {

            }
            finally
            {
                Console.Out.WriteLine("I was going to print this anyway.");
            }
            Console.Out.WriteLine("I'm okay now!");
        }
    }
}
