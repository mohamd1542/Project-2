using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Singleton
    {
        private static int counter = 0;
        public Singleton()
        {
            counter++;
            Console.WriteLine("An instance has been created!");
            Console.WriteLine("Num of availbal instance are " + counter);
        }

        private static Singleton myInstance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (myInstance==null)
                    myInstance = new Singleton();
                
                return myInstance;
            }
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message); 
        }
    }
}
