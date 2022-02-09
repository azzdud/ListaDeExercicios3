using System;

namespace Exercicio05.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor inicial: ");
            string strValor = Console.ReadLine();
            int valor = Convert.ToInt32(strValor);

            int fatorial = 1;

            Console.Write(valor + "! = ");

            for (int i = valor; i > 0; i--)
            {
                if (i != 1)
                    Console.Write(i + " x ");
                else
                    Console.Write(i);

                fatorial = fatorial * i;
            }

            Console.Write(" = " + fatorial);

            Console.ReadKey();
        }
    }
}