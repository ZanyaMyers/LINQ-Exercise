namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Halo 3" , "CODMW2" , "Left For Dead"};
            videoGames.Add("OSRS");
            videoGames.Add("2K16");

            var orderedGames = videoGames.OrderBy(name => name.Length); 

            foreach (var game in orderedGames)
            {
                Console.WriteLine("List of Games:");
                Console.WriteLine(game);
            }
        }
    }
}
