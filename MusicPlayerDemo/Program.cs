namespace MusicPlayerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boardgame bg = new Boardgame("Magic", "Juego de cartas", "Richard Garfield", "30 min", 9.5);

            bg.Title = "Yu gi Oh";

            Console.WriteLine(bg.Title);
        }
    }
}
