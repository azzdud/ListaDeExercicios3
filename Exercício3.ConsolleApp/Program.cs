/*Exercício 3
 * Desenvolver um algoritmo que efetue a soma de todos os números
ímpares que são múltiplos de três e que se encontram no conjunto dos
números de 1 até 500.*/

using System;

namespace Exercício3.ConsolleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma dos números ímpares múltiplos de 3 dentro" +
                "do conjunto de números de 1 até 500:\n");
            int acumulador = 0;

            for (int i = 0; i < 500; i++)
            {
                int numero = 0 + i;
                int teste = numero % 2;
                int teste2 = numero % 3;

                if (teste != 0 && teste2 == 0)
                {
                    acumulador = numero + acumulador;
                }
            }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A soma desses números é igual a: " + acumulador + "\n");
            
            Console.ReadLine();
        }
    }
}
