using System.Diagnostics.Metrics;
using System;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operaciones del reto
            // Crear la lista, agregar los valores y hacer las operaciones
            // Filtrar los libros con stock de mas de 10 unidades
            // Filtrar el stock por precio mas grande de 10.99 soles
            // Encontrar el indice del libro que empiece con "El"
            List<Libro> libros = new List<Libro>
            {
                new Libro
                {
                    Nombre = "Harry Potter",
                    Precio = 59.99,
                    Stock = 19
                },
                new Libro
                {
                    Nombre = "La ciudad y los perros",
                    Precio = 9.99,
                    Stock = 11
                },
                new Libro
                {
                    Nombre = "El llano en llamas",
                    Precio = 44.49,
                    Stock = 5
                },
                new Libro
                {
                    Nombre = "El principito",
                    Precio = 25.99,
                    Stock = 5
                },
            };

            // Filtrar los libros con stock de mas de 10 unidades
            List<Libro> librosStock10 = libros.Where(libro => libro.Stock > 10).ToList();

            Console.WriteLine("Libros con stock mayor a 10");
            foreach (var libro in librosStock10)
            {
                Console.WriteLine($"Titulo: {libro.Nombre} - Stock: {libro.Stock}");
            }


            // Filtrar el stock por precio mas grande de 10.99 soles
            List<Libro> librosPrecio10 = libros.Where(libro => libro.Precio > 10.99).ToList();

            Console.WriteLine("\nLibros con precio mayor a 10.99");
            foreach (var libro in librosPrecio10)
            {
                Console.WriteLine($"Titulo: {libro.Nombre} - Precio: {libro.Precio}");
            }

            // Libros que empiecen con "El"
            List<Libro> librosEl = libros.Where(libro => libro.Nombre.StartsWith("El")).ToList();

            Console.WriteLine("\nLibros que empiezan con El");
            foreach (var libro in librosEl)
            {
                Console.WriteLine($"Titulo: {libro.Nombre}");
            }
        }

        class Libro
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public int Stock { get; set; }
        }
    }

}
