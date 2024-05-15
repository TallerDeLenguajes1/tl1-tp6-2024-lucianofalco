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

Console.WriteLine("Ingrese un numero A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un numero B");
int B = Convert.ToInt32(Console.ReadLine());
int opcion = 0;

while (opcion != 5) // Cambia este número al número máximo de opciones en tu menú
{
    Console.WriteLine("Menú:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");

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
            Console.WriteLine("La suma de A + B es = " + A + B);
            break;
        case 2:
            Console.WriteLine("Has seleccionado la Opción 2");
            Console.WriteLine("La Resta de A - B es = " + (A - B));
            break;
        case 3:
            Console.WriteLine("Has seleccionado la Opción 3");
            Console.WriteLine("La multiplicacion de A * B es = " + A * B);
            break;
        case 4:
            Console.WriteLine("Has seleccionado la Opción 4");
            if (B == 0)
            {
                Console.WriteLine("Indefnido: no se puede dividir en cero");
            }
            else
            {
                Console.WriteLine("La division de A / b es = " + A / B);
            }
            break;
        case 5:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
            break;
    }
}



