namespace Repaso_Modulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios de los arreglos
            //contar los numeros que se repiten dentro de un arreglo
            int[] array = { 44, 44, 44, 23, 23, 23, 23, 25, 25, 30, 29, 25, 80 };

            HashSet<int> onlyNumbers = new HashSet<int>();

            HashSet<int> duplicatesSet = new HashSet<int>();


            foreach (int number in array)
            {
                if (onlyNumbers.Contains(number))
                {
                    duplicatesSet.Add(number);
                } else
                {
                    onlyNumbers.Add(number);
                } 
            }

            //mostrar resultados repetidos
            Console.WriteLine("Resultados repetidos:");
            foreach (int number in duplicatesSet)
            {
                Console.Write($"- {number} -");
            }



            
        }
    }
}
