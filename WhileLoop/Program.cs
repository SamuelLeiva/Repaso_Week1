namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tabla de multiplicar
            //int valorTabla;
            //int contador = 1;
            //int resultado;
            //Console.WriteLine("Ingrese el valor de la tabla de multiplicar");
            //valorTabla = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Tabla del " + valorTabla);

            //while(contador <= 12)
            //{
            //    resultado = valorTabla * contador;
            //    Console.WriteLine(valorTabla + " X " + contador + " = " + resultado);
            //    contador++;
            //}

            //cuadrado de 1 al 5

            //Console.WriteLine("Ingrese un número");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int inicio = 1; //numero de reglón
            

            //while(inicio <= num)
            //{
            //    int cont = 1; //numero de reglón
            //    while (cont <= num)
            //    {
            //        if( inicio >= cont)
            //        {
            //            Console.Write(cont + " ");
            //        } else
            //        {
            //            Console.Write("* ");
            //        }
                        
            //        cont++;
            //    }
            //    inicio++;
            //    Console.Write("\n");
            //}

            //1. Hacer tabla de multiplicar con for
            int valorTabla;
            int resultado;
            Console.WriteLine("Ingrese el valor de la tabla de multiplicar");
            valorTabla = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tabla del " + valorTabla);

            for(int i = 1; i <= 12; i++)
            {
                resultado = valorTabla * i;
                Console.WriteLine(valorTabla + " X " + i + " = " + resultado);
            }

            

            //2. Hacer el patrón de num y * con for
        }
    }
}
