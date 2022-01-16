using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class IsSymbol : IValidator
    {
        bool IValidator.Validation(string password)
        {
            var result = password.Any(x => Char.IsUpper(x));
            return result;
        }
    }
}
