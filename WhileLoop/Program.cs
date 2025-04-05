namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tabla de multiplicar
            int valorTabla;
            int contador = 1;
            int resultado;
            Console.WriteLine("Ingrese el valor de la tabla de multiplicar");
            valorTabla = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tabla del " + valorTabla);

            while(contador <= 12)
            {
                resultado = valorTabla * contador;
                Console.WriteLine(valorTabla + " X " + contador + " = " + resultado);
                contador++;
            }
        }
    }
}
