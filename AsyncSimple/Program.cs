namespace AsyncSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Started!");
            FirstCall();
            Console.WriteLine("After Calling the first call method");
            Console.ReadLine();
        }
        private static async Task FirstCall()
        {
            int value = await SecondCall();
            Console.WriteLine("The Rutern of calling the SecoundCall methodis : "+value);
        }
        private static Task<int> SecondCall() 
        {
            return Task.Run(() =>
            {
                Task.Delay(5000).Wait();
                return 20;
            });
        }
    }
}