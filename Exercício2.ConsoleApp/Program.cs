/*Exercício 2
 * Escrever um algoritmo que gera e escreve os números ímpares entre 100
e 200.*/

using System;

namespace Exercício2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                int numero = 100 + i;
                int par = numero % 2;

                if (par != 0)
                {
                    Console.Write(numero + ", ");
                    if (numero == 199)
                        Console.Write(numero + ".");
                }
            }
            Console.ReadLine();
        }
    }
}
