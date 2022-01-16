using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class IsUpper : IValidator
    {
        public bool Validation(string password)
        {
            var result = password.Any(x => Char.IsUpper(x));
            return result;
        }
    }
}
