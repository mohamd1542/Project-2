using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonLibrary
{
    public interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }
        string Description { get; set; }
        bool IsOrderCompleted { get; set; }

        void ShipeProduct(Customer customer);
    }
    public enum Status
    {
        Accepted,
        Readyl,
        Shipment,
        Recieved,
        Done
    }  
}
