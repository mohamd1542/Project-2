using System.Collections;

namespace DifferentType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList array = new ArrayList();
            array.Add("Hello World");
            array.Add(100);




            //var myGame = new Game();
            //myGame.Id = 1;  
            //myGame.Name = "FCB";
            //myGame.BestPlayer = new Player()
            //{
            //    Id = 1,
            //    Name = "mohamd",
            //    Score = 80,
            //};
            //Console.WriteLine(myGame.Summery);
            //Console.WriteLine(myGame.Summery.Key);
            //Console.WriteLine(myGame.Summery.Value);



            //var rr = myGame.Sum(2,3,5,9,756,4,3,2);
            //Console.WriteLine(rr);


            //Dictionary<string,int> map = new Dictionary<string,int>();
            //map.Add("Caira",960);
            //map.Add("USA", 960);
            //map.Add("Aleppo", 960);
            //foreach (var item in map)
            //{  
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}

            //Dictionary<int,Game>  todayMatches = new Dictionary<int,Game>();
            //todayMatches.Add(myGame.Id,myGame);

            //Dictionary<string,string> matcheData = new Dictionary<string,string>();
            //matcheData.Add("weather", "33");
            //matcheData.Add("numberofAtted", "5000");


            //if (matcheData.TryGetValue("weather", out string? weather))
            //    Console.WriteLine(weather);

            (string msg, bool rest) r = ValideAddress("mian street number: 5");
            var s = Tuple.Create(5,3.5,"MOhamd");    
          

        }
        public static (string message, bool resalt) ValideAddress(string address)
        {
            if (address.Equals("main street number: 5"))
            {
                return (address, true);
            }
            else
                return (address, false);
        }
    }     


    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Player BestPlayer { get; set; }

        public KeyValuePair<int ,string> Summery
        {
            get
            {
                return new KeyValuePair<int ,string>(Id, Name);
            }
        }

        public int Sum(params int[] values)
        {
            var resalt = 0;
            foreach (var item in values)
            {
                resalt += item;
            }
            return resalt;
        }
        public int Sum(int x, int y,int z)
        {
            return x + y + z;
        }
    }
    public struct Player
    {
        public Player(int Id ,string name,int score)
        {
            this.Id = Id;
            this.Name = name;
            this.Score = score;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

    }
}