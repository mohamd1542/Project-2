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
            
            //products = products.OrderByDescending(p => p.Name)
            //                   .ThenByDescending(p => p.Price)
            //                   .ToList();

            //products = products.Where(p => p.Price > 50 && p.Location == "Idleb").ToList();\

            //products = (from p in products
            //           where p.Location == "Idleb" && p.Price > 50
            //           select p).ToList();

            Console.WriteLine(products.Where(p => p.Location == "Idleb").Min(p => p.Price));
            Console.WriteLine(products.Where(p => p.Location == "Idleb").Max(p => p.Price));


            var groupByLocation = products.GroupBy(p => p.Location).ToList();

            int[] numbers1 = { 1, 2, 3, 4, 5, 6 };
            int[] numbers2 = { 2, 4, 7 };
            var unionItem = numbers1.Union(numbers2);
            var intersectItem = numbers1.Intersect(numbers2);
            var exceptItem = numbers1.Except(numbers2);

            //int result = numbers.Aggregate((a,b) => a * b);

            var newItem = products.Where(p => p.Price == 50).Select((p, Index) => new { Id = p.Id, Title = p.Name, Sequence = Index, Multi = p.Id * Index });
            //SelectMany
            var colors = products.SelectMany(p => p.Colors).ToList();


            //var oneTothreeItem = products.Take(3).ToList();
            var oneTothreeItem = products.TakeWhile(p => p.Price >50).ToList();
            //var threetosixItem = products.Skip(3).ToList();
            var threetosixItem = products.SkipWhile(p => p.Price > 50).ToList();

            var firstProduct = products.FirstOrDefault();
            var lastProduct = products.LastOrDefault();
            var single = products.SingleOrDefault(s => s.Name == "Mouse");
            var isKeyExists = products.Exists(s => s.Name == "Keyborad");

            //var onlyNames = products.Select(p => p.Name).ToList();
            var CammString = products.Select(p => p.Name).ToArray().Aggregate((a,b) => a + " , " +b);

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