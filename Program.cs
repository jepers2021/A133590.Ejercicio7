using System;

namespace A133590.Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 7");
            Console.Write("Por favor, ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hola {nombre}");

            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
