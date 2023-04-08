namespace LoggerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Extensions.Show("Hello World");


            ILogger logger = new Logger();
           
    
        }
    }
}