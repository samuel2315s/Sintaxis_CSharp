using System;

class Program
{
    static void Main()
    {
        // 1. Dimensiones iniciales
        int width = 7;
        int height = 5;

        // 2. Área
        int area = width * height;

        // 3. Perímetro
        int perimeter = 2 * width + 2 * height;

        // 4. Incrementar width en 3
        width += 3;

        // 5. Decrementar height en 2
        height -= 2;

        // 6. Recalcular área y perímetro
        area = width * height;
        perimeter = 2 * width + 2 * height;

        // 7. Mostrar valores finales
        Console.WriteLine("El ancho final es: " + width);
        Console.WriteLine("El alto final es: " + height);
        Console.WriteLine("El área final es: " + area);
        Console.WriteLine("El perímetro final es: " + perimeter);
    }
}
