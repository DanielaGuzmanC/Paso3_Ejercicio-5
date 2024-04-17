// nombre del estudiante: Daniela Guzman Cardenas
// Grupo:213022_386
// Numero y texto del programa: ejercicio 5 Se necesita capturar por teclado 8 números enteros entre 3 y 6 ambos incluidos. se debe establecer cuantas veces se repite los numero de 3 al 6 y hallar la potencia de cada uno esos numeros de acuerdo con las veces que se repita. se debe mostrar por pantalla los 8 numeros capturados y las pontencias de los numeros del 3 al 6. 
// Codigo de fuente:
using System;

class Program
{
    static void Main()
    {
        int contador3 = 0, contador4 = 0, contador5 = 0, contador6 = 0;
        int potencia3 = 0, potencia4 = 0, potencia5 = 0, potencia6 = 0;
        int numero;

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 3 && numero <= 6)
            {
                switch (numero)
                {
                    case 3:
                        contador3++;
                        potencia3 = (int)Math.Pow(3, contador3);
                        break;
                    case 4:
                        contador4++;
                        potencia4 = (int)Math.Pow(4, contador4);
                        break;
                    case 5:
                        contador5++;
                        potencia5 = (int)Math.Pow(5, contador5);
                        break;
                    case 6:
                        contador6++;
                        potencia6 = (int)Math.Pow(6, contador6);
                        break;
                }
            }
        }

        Console.WriteLine("\nNúmeros capturados:");
        Console.WriteLine($"3: {contador3} veces, potencia: {potencia3}");
        Console.WriteLine($"4: {contador4} veces, potencia: {potencia4}");
        Console.WriteLine($"5: {contador5} veces, potencia: {potencia5}");
        Console.WriteLine($"6: {contador6} veces, potencia: {potencia6}");
    }
}

