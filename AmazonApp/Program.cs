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
        private static List<Product> fillTheCart()
        {
            var card = new List<Product>
            {
                new Product { Name = "How to trian your dragon " },
                new Product { Name = "learn Csharp in 30 min " },
                new Product { Name = "learn Sql in 30 min " }
            };

            return card;
        }
    }
}