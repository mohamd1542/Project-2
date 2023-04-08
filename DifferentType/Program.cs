namespace DifferentType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myGame = new Game();
            myGame.Id = 1;  
            myGame.Name = "FCB";
            myGame.BestPlayer = new Player()
            {
                Id = 1,
                Name = "mohamd",
                Score = 80,
            };
            var rr = myGame.Sum(2,3,5,9,756,4,3,2);
            Console.WriteLine(rr);
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