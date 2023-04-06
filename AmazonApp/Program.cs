using AmazonLibrary;
namespace AmazonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCard = fillTheCart();
            Customer customer = new Customer();
            customer.FirstName = "Mohamed";
            customer.City = "Dubai";

            foreach (var item in myCard)
            {
                item.ShipeProduct(customer);
            }
        }
        private static List<IProduct> fillTheCart()
        {
            var card = new List<IProduct>
            {
                new PhysicalProduct { Name = "How to trian your dragon " },
                new PhysicalProduct { Name = "learn Csharp in 30 min " },
                new PhysicalProduct { Name = "learn Sql in 30 min " },
                new DigitalProduct {Name = "Empty music"},
                new CourseProdect {Name = "learn c++ in 30 hourses"}
               

            };

            return card;
        }
    }
}
