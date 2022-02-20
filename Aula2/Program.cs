using System;

namespace Aula2
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //Para executar basta tirar o comentário da função desejada
            //POR EXEMPLO: abaixo vai ser executado apenas o inicio
            inicio();
            OperadorAritmetico();
        }
        static void inicio()
        {
            //COMO DECLARAR UM VARIÁVEL
            //TIPO depois o nome; <- no final de todas as linhas 

            //linha verde ou amarela(VS code) = a variavel criada não esta sendo utilizada

            //1 sinal de igual representa atribuição.

            //Comentarios

            /*
                Comentário para mais de uma linha.
            */

            //Declarar uma variável?
            // tipo nomevariável
            
            string name;
            int idade;

            //Para atribuir um valor a variável
            // utilizamos o sinal de =

            name = "Jackson";
            idade = 34;

            Console.WriteLine(name);
            Console.WriteLine(idade);
        }
        
        static void OperadorAritmetico()
        {
            //tipo //nome da variável // sinal de = representa atribuição

            int numero1 = 1;
            int numero2 = 30;
            int numero3 = 20;

            // + juntar o texto com o número. //parenteses conta, +(soma)
            //soma de todas  as variaveis do tipo int.
            Console.WriteLine("Soma de todos os números: " + (numero1 + numero2 + numero3));

            // Comando para duplicar linha Ctrl + D
            //subtração de todas as variaveis do tipo int
            Console.WriteLine("Subtração: " + (numero3 - numero2 - numero1));
            //multiplicação de todas as variaveis do tipo int
            Console.WriteLine("Multiplicação: " + (numero3 * numero2 * numero1));
            //divisão de todas as variaveis do tipo int
            Console.WriteLine("Divisão: " + (numero3 / numero2));
        }
    }
}
    

