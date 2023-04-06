using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonLibrary
{
    public class CourseProdect : IProduct
    {
        public string Name { get; set ; }
        public double Price { get ; set ; }
        public string Description { get ; set ; }
        public bool IsOrderCompleted { get ; set; }

        public void ShipeProduct(Customer customer)
        {
            
        }
    }
}
