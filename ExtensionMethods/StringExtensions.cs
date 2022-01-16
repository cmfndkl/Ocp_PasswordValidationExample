using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool IsValidPassword(this string str, params IValidator[] args)
        {
            var result = true;
            foreach (var arg in args)
            {
                result = result && arg.Validation(str);
            }
            return result;
        }
    }
}
