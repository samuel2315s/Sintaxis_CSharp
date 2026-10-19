
using System;

class Program
{
    static void Main()
    {
        // Declaracion de variables
        int num1 = 20;
        int num2 = 5;

        // Operadores aritmeticos
        int suma = num1 + num2;
        int resta = num1 - num2;
        int multiplicacion = num1 * num2;
        int division = num1 / num2;
        int modulo = num1 % num2;

        // Impresion de resultados
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicacion: " + multiplicacion);
        Console.WriteLine("Division: " + division);
        Console.WriteLine("Modulo: " + modulo);

        // Operadores de asignacion
        int numero = 10;

        numero += 5;
        Console.WriteLine("Suma con asignacion (+=): " + numero);

        numero -= 3;
        Console.WriteLine("Resta con asignacion (-=): " + numero);

        numero *= 2;
        Console.WriteLine("Multiplicacion con asignacion (*=): " + numero);

        numero /= 4;
        Console.WriteLine("Division con asignacion (/=): " + numero);

        Console.ReadKey();
    }
}

