namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton firstInstance = new Singleton();
            //firstInstance.ShowMessage("First Message");

            //Singleton scoundInstance = new Singleton();
            //scoundInstance.ShowMessage("Scound Message");

            var s = Singleton.GetInstance;
        }
    }
}