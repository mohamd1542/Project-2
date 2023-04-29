using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class LimitedGenericClass<T> where T : class, IStudents
    {
        public void GenericMethod(T param1 ,T param2)
        {
            var param1Type = param1.GetType();
            var param2Type = param2.GetType();

            Console.WriteLine("The type of first parameter is ",param1Type);
            Console.WriteLine("The type of secound parameter is ", param2Type);
            

            var propertiesInfo1 = param1.GetType().GetProperties();
            var propertiesInfo2 = param1.GetType().GetProperties();

            foreach (var proparty in propertiesInfo1)
            {
                var value = proparty.GetValue(param1);
                Console.WriteLine($"{proparty.Name}: {value}");
            }
            foreach (var property in propertiesInfo2)
            {
                var value = property.GetValue(param2);
                Console.WriteLine($"{property.Name}: {value}");
            }

        }
    }
}
