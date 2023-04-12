using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericClass<T>
    {
        public GenericClass(string name ,string description, T item)
        { 
            Name = name;
            Description = description;
            Item = item;

        }
        public string Name { get; set; }
        public string Description { get; set; }
        public T Item { get; set; }
       

    }
}
