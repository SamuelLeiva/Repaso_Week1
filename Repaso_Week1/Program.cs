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

            //Área del círculo o cuadrado
            Console.WriteLine("Ingrese el área que desea calcular\n" +
                "1.Triángulo\n" +
                "2.Círculo");
            int opcion = Convert.ToInt32(Console.ReadLine());

            double resultado;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la base del triángulo");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triángulo");
                    double h = Convert.ToDouble(Console.ReadLine());
                    resultado = b * h / 2;
                    Console.WriteLine("Área del triángulo: " + resultado);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el radio del círculo");
                    double r = Convert.ToDouble(Console.ReadLine());
                    resultado = Math.PI * r * r;
                    Console.WriteLine("Área del círculo: " + resultado);
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}
