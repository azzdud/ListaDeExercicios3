/*Exercício 5
 * Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
valores do cálculo de A! e o seu resultado.
Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
• Pesquise sobre “fatorial”*/

using System;

namespace Exercício5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para saber seu fatorial: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int resultado = 1;

            for (int i = num; i > 0; i--)
            {
                if (i != 1)
                    Console.Write(i + " x ");
                else
                    Console.Write(i);

                resultado = resultado * i;
            }            
            
            Console.Write(" = ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(resultado);

            Console.ReadLine();
        }
    }
}
