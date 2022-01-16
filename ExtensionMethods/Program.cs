using System;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "Cmfndkl.1";
            Console.WriteLine(password.IsValidPassword(new IsUpper(),new IsDigit(),new IsSymbol()));
        }
    }
}
