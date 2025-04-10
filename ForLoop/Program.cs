using static System.Net.Mime.MediaTypeNames;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer tabla de multiplicar con for
            int valorTabla;
            int resultado;
            Console.WriteLine("Ingrese el valor de la tabla de multiplicar");
            valorTabla = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tabla del " + valorTabla);

            for (int i = 1; i <= 12; i++)
            {
                resultado = valorTabla * i;
                Console.WriteLine(valorTabla + " X " + i + " = " + resultado);
            }

            //2. Hacer el patrón de num y * con for
            Console.WriteLine("Ingrese el valor para el patrón");
            int valor = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= valor; j++) //reglón
            {   
                for (int k = 1; k <= valor; k++) //caracter
                {
                    if (j >= k)
                    {
                        Console.Write(k + " ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.Write('\n');
            }

            //3. Pirámide de * centrada
            Console.WriteLine("Ingrese el tamaño de la pirámide");
            int altura = Convert.ToInt32(Console.ReadLine());
            for (int y = 1; y <= altura; y++)
            {
                for (int x = 1; x <= altura - y; x++) //imprime espacios hasta el espacio altura-y
                {
                    Console.Write(" ");
                }

                //imprimimos * con espacio
                for(int x = 1; x <= y; x++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
