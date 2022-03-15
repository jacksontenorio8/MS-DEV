using System;

namespace Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For();
            Array();
        } 

        static void For()
        {
            //FOR
            
            //EXIBIR NÚMEROS ATÉ 50.
            
            //for TAB + TAB
            
            //i = inicio da variavel. INDEX

            // i < 50 = condição para a quantidade de vezes que o bloco vai executar

            //i++ = controle que vai adcionar i + 1 até chegar em 50.

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Array()
        {
            //ARRAY ("VETOR")
            //posições [0], [1], [2], [3], [4], [5], [6]

            int[] numeros_loteria = { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine("Posição 2: " + numeros_loteria[2]);

            for(int i = 0; i < numeros_loteria.Length; i++)
            {
                Console.WriteLine(numeros_loteria[i]);
            }
        }
        
    }
}
