namespace Repaso_Week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor a comprobar: ");
            int numero = Convert.ToInt32 (Console.ReadLine());

            if (numero % 2 == 0) 
            {
                Console.WriteLine("El número es par");
            } 
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
    }
}
