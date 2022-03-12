using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int total = 0;
            string operacao = "";

            Console.WriteLine("Programa que faz operações com dois números!");
            numero1 = Teclado("Digite o 1º número: ");
            numero2 = Teclado("Digite o 2º número: ");
            Console.WriteLine("Informe a operação a ser realizada (adição, subtração, multiplicação e divisão): ");
            operacao = Console.ReadLine;
        }

    }
}
