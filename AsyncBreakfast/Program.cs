namespace AsyncBreakfast
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Coffee coffee = PrepareCoffee();
            Console.WriteLine("Coffee is ready");
            Task<Egg> egg = FryEggs(3);
            Task<Milk> milk = prepareMilk();
            Task<Toast> toast = PrepareToast(2);

            var AllTask = new List<Task>() { egg,milk,toast};
            while (AllTask.Any())
            {
                Task finished = await Task.WhenAny(AllTask);
                if (finished == egg)
                    Console.WriteLine("Egg is ready");
                else if (finished == milk)
                    Console.WriteLine("Milk is ready");
                else if (finished == toast)
                    Console.WriteLine("Toast is ready");

                AllTask.Remove(finished);
            }

            Console.WriteLine("Your Breakfast is Ready!");
        }



        private static async Task<Toast> PrepareToast(int slices)
        {
            Console.WriteLine("Warming the toaster .....");
            await Task.Delay(1000);
            for (int i = 0; i < slices; i++) 
            {
                await Task.Delay(1000);
                Console.WriteLine($"putting a slice num :{i} in the toaster");
            }
            Console.WriteLine("removing the toast from the toaster ...");
            return new Toast();
        }

        private static async Task<Milk> prepareMilk()
        {
            Console.WriteLine("Warming the Milk Cup ....");
            await Task.Delay(1000);
            return new Milk();
        }

        private static async Task<Egg> FryEggs(int v)
        {
            Console.WriteLine("Warming the egg plate ....");
            await Task.Delay(1000);
            Console.WriteLine($"Cooking {3} eggs");
            await Task.Delay(1000);
            Console.WriteLine("Put the Eggs on the plate");
            return new Egg();
        }
        private static Coffee PrepareCoffee()
        {
            Console.WriteLine("Prepareing Coffee .......");
            return new Coffee();
        }
    }
}