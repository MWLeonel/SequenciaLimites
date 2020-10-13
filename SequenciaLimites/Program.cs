using System;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;

            Console.Write("Digite o 1ºNúmero: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2ºNúmero: ");
            valor2 = int.Parse(Console.ReadLine());

            for (int i = valor1; i <= valor2 ; i++)
            {
                if (valor2 < valor1)
                {
                    Console.WriteLine("ERRO! O 2ºValor tem que ser maior que o 1ºValor");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
