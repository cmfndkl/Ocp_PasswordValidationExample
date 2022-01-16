using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class IsDigit : IValidator
    {
        public bool Validation(string password)
        {
            var result = password.Any(x => Char.IsDigit(x));
            return result;
        }
    }
}
