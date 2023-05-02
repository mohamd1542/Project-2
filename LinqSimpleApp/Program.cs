namespace LinqSimpleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var addition = (int x, int y) => x + y;
            var reaslt = addition(100, 200);
            Console.WriteLine(reaslt);

            var products = GSProduct();
            
            products = products.OrderByDescending(p => p.Name)
                               .ThenByDescending(p => p.Price)
                               .ToList();

            //products = products.Where(p => p.Price > 50 && p.Location == "Idleb").ToList();\

            //products = (from p in products
            //           where p.Location == "Idleb" && p.Price > 50
            //           select p).ToList();

            var groupByLocation = products.GroupBy(p => p.Location).ToList();   


            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id} - {product.Name} - {product.Price} - {product.Location}");
            }


        }

        public static void ShowMessage(string msg) =>
 
            Console.WriteLine(msg);

        private static List<Product>  GSProduct()
        {
            return new List<Product>
            {
                new Product(){ Id = 1,Name = "Book",Price = 100,Location = "Idleb",Colors = new List<string>{"Red","Bule"} },
                new Product(){ Id = 2,Name = "Pc",Price = 60,Location = "Alepoo",Colors = new List<string>{"White","Black"} },
                new Product(){ Id = 3,Name = "Mouse",Price = 80,Location = "Idleb",Colors = new List<string>{"Yallow","Bule"} },
                new Product(){ Id = 4,Name = "Keyborad",Price = 45,Location = "Alepoo",Colors = new List<string>{"Purple","Bule"} },
                new Product(){ Id = 5,Name = "Watch",Price = 50,Location = "Idleb",Colors = new List<string>{"Red","Pink"} },
                new Product(){ Id = 6,Name = "PC",Price = 70,Location = "Alepoo",Colors = new List<string>{"Red","Black"} },
                new Product(){ Id = 7,Name = "Book",Price = 120,Location = "Idleb",Colors = new List<string>{"Red","Green"} },
            };
        }
    }
}