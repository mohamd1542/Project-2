using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericEqulator
    {
        public static bool AerEqual<T>(T value1 , T value2)
        {
            List<string> list = new List<string>();
            return value1.Equals(value1);
        }
        
    }
}
