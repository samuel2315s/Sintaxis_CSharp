using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Para que el promedio se muestre como 73.4 (con punto) y no 73,4
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        // ===== Datos base =====
        int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

        // =====================================================
        // SECCIÓN 1 — For y Foreach
        // =====================================================

        // Paso 2: for ascendente
        Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        // Paso 3: for descendente
        Console.WriteLine("\n=== ORDEN DESCENDENTE ===");
        for (int i = calificaciones.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        // Paso 4: foreach para suma y promedio
        Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");
        int suma = 0;
        foreach (int nota in calificaciones)
        {
            suma += nota;
        }
        double promedio = (double)suma / calificaciones.Length;
        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Promedio: {promedio}");

        // Paso 5: for con incremento de 2 (índices 0, 2, 4, ...)
        Console.WriteLine("\n=== POSICIONES PARES ===");
        for (int i = 0; i < calificaciones.Length; i += 2)
        {
            Console.WriteLine($"Posición par: {calificaciones[i]}");
        }

        // =====================================================
        // SECCIÓN 2 — While y Do-While
        // =====================================================

        // Paso 1: while - control de acceso
        Console.WriteLine("\n=== CONTROL DE ACCESO ===");
        int intentos = 0;
        string clave = "sena2025";
        bool accesoConcedido = false;

        while (!accesoConcedido && intentos < 3)
        {
            Console.Write("Ingresa la clave: ");
            string intento = Console.ReadLine() ?? "";

            if (intento == clave)
            {
                accesoConcedido = true;
            }
            else
            {
                intentos++;
                Console.WriteLine($"Clave incorrecta. Intentos restantes: {3 - intentos}");
            }
        }

        if (accesoConcedido)
        {
            Console.WriteLine("Acceso concedido.");
        }
        else
        {
            Console.WriteLine("Acceso bloqueado.");
        }

        // Paso 2: do-while - menú de opciones
        Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
        int opcion;

        do
        {
            Console.WriteLine("1. Ver promedio del grupo");
            Console.WriteLine("2. Ver calificación más alta");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = 0; // texto no numérico = opción inválida
            }

            if (opcion == 1)
            {
                Console.WriteLine($"Promedio del grupo: {promedio}");
            }
            else if (opcion == 2)
            {
                int mayor = calificaciones[0];
                foreach (int nota in calificaciones)
                {
                    if (nota > mayor)
                    {
                        mayor = nota;
                    }
                }
                Console.WriteLine($"Calificación más alta: {mayor}");
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Hasta luego.");
            }
            else
            {
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
            }

            Console.WriteLine();
        } while (opcion != 3);

        // =====================================================
        // SECCIÓN 3 — Break y Continue
        // =====================================================

        // Paso 1: for con break - primera calificación reprobatoria
        Console.WriteLine("=== PRIMERA CALIFICACIÓN REPROBATORIA ===");
        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 60)
            {
                Console.WriteLine($"Encontrada en la posición {i + 1}: {calificaciones[i]}");
                break;
            }
        }

        // Paso 2: foreach con continue - solo aprobados
        Console.WriteLine("\n=== CALIFICACIONES APROBATORIAS ===");
        int aprobados = 0;
        foreach (int nota in calificaciones)
        {
            if (nota < 60)
            {
                continue;
            }
            Console.WriteLine($"Aprobó con: {nota}");
            aprobados++;
        }
        Console.WriteLine($"Total de estudiantes aprobados: {aprobados}");

        // Paso 3: for con continue y break combinados
        Console.WriteLine("\n=== FILTRO COMBINADO ===");
        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 70)
            {
                continue; // salta las menores a 70
            }

            if (calificaciones[i] >= 95)
            {
                break; // detiene el recorrido
            }

            Console.WriteLine($"Calificación procesada: {calificaciones[i]}");
        }
    }
}
