
using System;

class Program
{
    static void Main()
    {
        // Declaracion de variables
        string nombre = "Samuel";
        int edad = 18;
        double nota1 = 4.5;
        double nota2 = 3.8;

        // Calcular el promedio
        double promedio = (nota1 + nota2) / 2;

        // Mostrar resultados usando interpolacion de strings
        Console.WriteLine($"Nombre del estudiante: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Primera nota: {nota1}");
        Console.WriteLine($"Segunda nota: {nota2}");
        Console.WriteLine($"Promedio final: {promedio}");

        Console.ReadKey();
    }
}
