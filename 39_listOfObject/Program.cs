namespace _39_listOfObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Mansoor Ahmed");
            Player player2 = new Player("Muhammad Siddique");
            Player player3 = new Player("Ayesha");

            // list of object

            List<Player> players = new List<Player>();

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach(Player player in players)
            {
                Console.WriteLine(player.userName);

            }
            
        }
    }

    class Player
    {
        public String userName;

        public Player(String userName)
        {
            this.userName = userName;

        }
    }
}
