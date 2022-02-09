/*Exercício 4
 * Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e
calcule a tabuada de N.
• Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N =
10N.*/

using System;

namespace Exercício4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tabuada você deseja?");
            int num = Convert.ToInt32(Console.ReadLine());            
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = num * i;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(num);
                    Console.ResetColor();
                    Console.Write(" X " + i + " = ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(resultado + "\n");
                    Console.ResetColor();                    
                }
            Console.ReadLine();
        }
    }
}
