namespace AsyncSample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> r = DoCalculationAsync();
            Console.WriteLine("After calling the docalculationAsync");
            Console.WriteLine("thr resalt of doing the calculation is : "+r.Result);
        }

        private static async Task<int> DoCalculationAsync()
        {
            Console.WriteLine("In Async Method");
            await Task.Delay(5000);
            Console.WriteLine("the delay has been finished ,but I am inside the Async method");
            return 10 + 40;
        }
    }
}