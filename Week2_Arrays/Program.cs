namespace Week2_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 10;
            y = 45;

            Console.WriteLine(Add(x, y));
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
    }

    
}
