using System.Dynamic;

namespace Repaso_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boardgame bg1 = new Boardgame("Gloomhaven", "Isaac Childres", 8.7, 120, 3.8);

            Console.WriteLine($"Titulo: {bg1.Title}");
        }
    }
}
