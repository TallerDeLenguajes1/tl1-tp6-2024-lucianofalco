// See https://aka.ms/new-console-template for more information
/*
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
*/

using System;
using System.Linq.Expressions;

float A;
float numero;
float numero2;
Console.WriteLine("Ingrese un numero");
while (!float.TryParse(Console.ReadLine(), out A))
{
    Console.WriteLine("Por favor, introduce un número válido.");
    continue;
}

int opcion = 0;

while (opcion != 6) // Cambia este número al número máximo de opciones en tu menú
{
    Console.WriteLine();
    Console.WriteLine("Menú:");
    Console.WriteLine("1. Valor absoluto");
    Console.WriteLine("2. Cuadrado");
    Console.WriteLine("3. Raiz cuadrada");
    Console.WriteLine("4. Seno");
    Console.WriteLine("5. Coseno");
    Console.WriteLine("6. Salir");
    Console.Write("Elige una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Por favor, introduce un número válido.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Has seleccionado la Opción 1");
            Console.WriteLine("Valor absoluto = " + Math.Abs(A));
            break;

        case 2:
            Console.WriteLine("Has seleccionado la Opción 2");
            Console.WriteLine("A al cuadrado: " + Math.Pow(A, 2));
            break;

        case 3:
            Console.WriteLine("Has seleccionado la Opción 3");
            Console.WriteLine("La rais cuadrada es: " + Math.Sqrt(A));
            break;

        case 4:
            Console.WriteLine("Has seleccionado la Opción 4");
            Console.WriteLine("El seno es: " + Math.Asin(A));
            break;

        case 5:
            Console.WriteLine("Has seleccionado la Opción 5");
            Console.WriteLine("El coseno es: " + Math.Acos(A));
            break;

        case 6:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
            break;
    }

    Console.WriteLine("Ingrese un numero.");
    if (!float.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Por favor, introduce un número válido.");
        continue;
    }
    Console.WriteLine("Ingrese un numero.");
    if (!float.TryParse(Console.ReadLine(), out numero2))
    {
        Console.WriteLine("Por favor, introduce un número válido.");
        continue;
    }

    // Calcular y mostrar la parte entera del número (truncamiento)
    Console.WriteLine($"Parte entera: {Math.Truncate(numero)}");

    // Calcular y mostrar el máximo entre los dos números
    Console.WriteLine($"Máximo entre {numero} y {numero2}: {Math.Max(numero, numero2)}");

    // Calcular y mostrar el mínimo entre los dos números
    Console.WriteLine($"Mínimo entre {numero} y {numero2}: {Math.Min(numero, numero2)}");

}



