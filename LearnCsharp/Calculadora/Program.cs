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
            Console.WriteLine("Informe a operação a ser realizada (Adicao, Subtracao, Multiplicacao e Divisao): ");
            operacao = Console.ReadLine();

            if (operacao == "Adicao") {

                total = Adicao(numero1, numero2);
                Console.WriteLine(numero1 + " + " + numero2 + " = " + total);
            }
            
            if (operacao == "Subtracao") {

                total = Subtracao(numero1, numero2);
                Console.WriteLine(numero1 + " - " + numero2 + " = " + total);
            }
            
            if (operacao == "Multiplicacao") {

                total = Multiplicacao(numero1, numero2);
                Console.WriteLine(numero1 + " x " + numero2 + " = " + total);
            }
            
            if (operacao == "Divisao") {

                total = Divisao(numero1, numero2);
                Console.WriteLine(numero1 + " / " + numero2 + " = " + total);
            }
        }
        static int Teclado(string texto)
        {
            Console.Write(texto);
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }

        static int Adicao(int numero1, int numero2)
        {
            int total = 0;
            total = numero1 + numero2;
            return total;
        }

        static int Subtracao(int numero1, int numero2)
        {
            int total = 0;
            total = numero1 - numero2;
            return total;
        } 
        
        static int Multiplicacao(int numero1, int numero2)
        {
            int total = 0;
            total = numero1 * numero2;
            return total;

        } 
        
        static int Divisao(int numero1, int numero2)
        {
            int total = 0;

            if(numero2 > 0)
            {
                total = 0;
                total = numero1 / numero2;
            }
            
            else
            {
                total = 0;
            }
            return total;
        }

    }
}
