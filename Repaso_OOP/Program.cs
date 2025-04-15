using System.Dynamic;

namespace Repaso_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class Song()
        {
            public string name;
            public string artist;
            public string genre;
            public string albumName;
            public int durationSeconds;

            public Song(string name, string artist, string genre, string albumName, int durationSeconds) : this()
            {
                this.name = name;
                this.artist = artist;
                this.genre = genre;
                this.albumName = albumName;
                this.durationSeconds = durationSeconds;
            }
        }
    }
}
