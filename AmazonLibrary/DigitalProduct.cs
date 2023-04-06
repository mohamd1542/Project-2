using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonLibrary
{
    public class DigitalProduct : IProduct 
    {
        public string Name { get ; set; }
        public double Price { get ; set ; }
        public string Description { get ; set ; }
        public bool IsOrderCompleted { get ; set ; }
        public string Extension { get; set; }
        public int TotalNumberOfAvailableDownloads { get; set; } = 3;

        public void ShipeProduct(Customer customer)
        {
            if (IsOrderCompleted == false)
            {
                Console.WriteLine("emailing the " + this.Name + " to " + customer.FirstName + " in " + customer.City);
                this.TotalNumberOfAvailableDownloads -= 1;
                

                if (this.TotalNumberOfAvailableDownloads < 1)
                {
                    this.IsOrderCompleted = true;
                    TotalNumberOfAvailableDownloads = 0;
                }
            }  

        }
    }
}
