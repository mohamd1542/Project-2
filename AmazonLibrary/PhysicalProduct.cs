using AmazonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonLibrary
{
    public sealed class PhysicalProduct : IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get ; set; }
        public bool IsOrderCompleted { get; set; }

        public int Weight { get; set; }
        public Status Status { get; set; }

        public void ShipeProduct(Customer customer)
        {
            if (this.IsOrderCompleted == false)
            {
                Console.WriteLine("Shipping the " + this.Name + " to " + customer.FirstName + " in " + customer.City);
            }
        }
    }
}


        