using System;

namespace Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            #endregion
            methodOne();
        }
        static void methodOne()
        {
            methodTwo();
        }
        static void methodTwo()
        {
            throw new Exception();
        }
    }
}
