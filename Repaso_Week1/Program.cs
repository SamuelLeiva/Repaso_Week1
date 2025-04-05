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

            Console.WriteLine("Cuál es el numero mayor de 3 números ");
            Console.WriteLine("Ingrese el primer número");
            int primerNumero = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            int tercerNumero = Convert.ToInt32(Console.ReadLine());

            if(primerNumero > segundoNumero && primerNumero > tercerNumero)
            {
                Console.WriteLine(primerNumero + " es el número mayor");
            }
            else if (segundoNumero > primerNumero && segundoNumero > tercerNumero)
            {
                Console.WriteLine(segundoNumero + " es el número mayor");
            }
            else if (tercerNumero > primerNumero && tercerNumero > segundoNumero)
            {
                Console.WriteLine(tercerNumero + " es el número mayor");
            }
            else
            {
                Console.WriteLine("Todos los números son iguales");
            }
          
        }
    }
}
