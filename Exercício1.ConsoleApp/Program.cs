/*Exercício 1
 * Desenvolver um algoritmo que leia a altura de 15 pessoas. Este
programa deverá calcular e mostrar:
a. A menor altura do grupo;
b. A maior altura do grupo;*/

using System;

namespace Exercício1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maiorAlt = 0, menorAlt = 1000, alt;

            for (int i = 0; i < 15; i++) 
            {
                Console.Write("Digite a altura número " + i + ": ");
                alt = Convert.ToDouble(Console.ReadLine());

                if (alt > maiorAlt)
                {
                    maiorAlt = alt;
                }
                if (alt < menorAlt)
                {
                    menorAlt = alt;
                }
            }
            Console.Write("\nA maior altura é ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(maiorAlt);
            Console.ResetColor();

            Console.Write("\nE a menor altura é ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(menorAlt);
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
