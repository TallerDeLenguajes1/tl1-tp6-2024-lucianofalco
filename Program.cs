// See https://aka.ms/new-console-template for more information
/*
Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.
Nota: Si observa un subrayado amarillo sugiriendo modificar las variables al tipo
"nullable", abra el archivo de configuración de proyecto de extensión .csproj y elimine
la línea que dice <Nullable>enable</Nullable>. No olvide guardar el archivo
*/

using System;

Console.WriteLine("Ingrese un numero");
int numero =  Convert.ToInt32(Console.ReadLine());
int inverso = 0;
while (numero != 0)
{
    int digito = numero % 10 ;
    inverso = inverso * 10 + digito ;
    numero /= 10 ;
}

Console.WriteLine(inverso) ;
