namespace Week2_ArrayUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] grades = new double[10];

            EnterGrades(grades);

            // // 3. Mostrar todas las calificaciones
            showGrades(grades);

            // // 4. Calcular y mostrar estadísticas
            Console.WriteLine($"Promedio de las calificaciones: {calculateAverageGrade(grades)}");

            // Notas maxima y minima
            Console.WriteLine($"Nota máxima: {getMax(grades)}");
            Console.WriteLine($"Nota mínima: {getMin(grades)}");

            // // 5. Ordenar y mostrar calificaciones
            orderGrades(grades);

            // // 6. Mostrar distribución por rangos
            showGradesDistribution(grades);

        }

        private static void EnterGrades(double[] grades)
        {
            int countGrade = 1;
            double grade;
            do
            {
                Console.WriteLine("Ingrese una calificación");
                grade = Convert.ToDouble(Console.ReadLine());

                if(grade >= 0 && grade <= 100)
                {
                    grades[countGrade-1] = grade;
                    countGrade++;
                }
                else
                {
                    Console.WriteLine("Calificación incorrecta");
                }
            }
            while (countGrade <= grades.Length);
        }

        private static void showGrades(double[] grades)
        {
            Console.WriteLine("Calificaciones: ");
            foreach(double grade in grades)
            {
                Console.WriteLine($"Nota {Array.IndexOf(grades, grade) + 1}: {grade}");
            }
        }

        private static double calculateAverageGrade(double[] grades)
        {
            double total = 0;
            foreach(double grade in grades)
            {
                total += grade;
            }

            double averageGrade = total / grades.Length;

            return averageGrade;
        }

        private static double getMax (double[] grades)
        {
            double max = 0;
            foreach (double grade in grades)
            {
                if(grade > max)
                {
                    max = grade;
                }
            }
            return max;
        }

        private static double getMin(double[] grades)
        {
            double min = 100;
            foreach (double grade in grades)
            {
                if (grade < min)
                {
                    min = grade;
                }
            }
            return min;
        }

        private static void orderGrades(double[] grades)
        {
            Array.Sort(grades);
            Console.WriteLine("Notas ordenadas: ");
            foreach (double grade in grades)
            {
                Console.WriteLine($"- {grade}");
            }
        }

        private static void showGradesDistribution(double[] grades)
        {
            int numDesaproved = 0, numEnough = 0, numGood = 0, numNotable = 0, numExcelent = 0;

            foreach (var grade in grades)
            {
                if(grade <= 59)
                {
                    numDesaproved++;
                } else if (grade > 59 && grade <=69) {
                    numEnough++;
                } else if (grade > 69 && grade <=79)
                {
                    numGood++;
                }
                else if (grade > 79 && grade <= 89)
                {
                    numNotable++;
                }
                else if (grade > 89 && grade <= 100)
                {
                    numExcelent++;
                }
            }

            Console.WriteLine($"Estudiantes Reprobados: {numDesaproved}");
            Console.WriteLine($"Estudiantes Suficientes: {numEnough}");
            Console.WriteLine($"Estudiantes Bien: {numGood}");
            Console.WriteLine($"Estudiantes Notables: {numNotable}");
            Console.WriteLine($"Estudiantes Excelentes: {numExcelent}");
        }
    }
}
