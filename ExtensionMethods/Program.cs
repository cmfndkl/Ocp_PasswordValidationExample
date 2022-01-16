using System;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "Cmfndkl11@";
            Console.WriteLine(password.IsValidPassword(new IsUpper(),new IsDigit()));
        }
    }
}
