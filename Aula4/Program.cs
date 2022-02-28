using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para executar basta tirar o comentário da função desejada.

            //POR EXEMPLO: abaixo vai ser executado apenas o IFsimples.

            //IFsimples();
            //IFElse();
            IFElseIf();
        }

        static void IFsimples()
        {
            //IF - SE - IF SIMPLES

            int x = 10;
            Console.WriteLine("Bom dia!");

            if (x != 5)//se a condição for verdadeira executa o bloco abaixo
            {
                Console.WriteLine("Boa tarde!");
            }
            Console.WriteLine("Boa noite!");
        }

        static void IFElse()
        {
            //CRIE UM PROGRAMA QUE VAI  RECEBER UM NÚMEROS
            //INFORMAR SE O NÚMERO É PAR OU ÍMPAR

            Console.WriteLine("Entre com um número: ");

            //converter string para int

            int numero = int.Parse(Console.ReadLine());

            //Testar se é par ou ímpar.

            //divide por 2 e recupera o resto da divisão.

            if (numero % 2 == 0)
            {
                Console.WriteLine("É par!");
            }
            else
            {
                Console.WriteLine("É ímpar!");
            }
        }

        static void IFElseIf()
        {
            Console.WriteLine("Qual é a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            /*
            if(hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }

            if(hora >= 12  && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }

            if (hora >= 18)
            {
                Console.WriteLine("Boa noite!");
            } 
            */

            //ENCADEAMENTO
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }

            //DICA - se o if ou o else tiver apenas uma linha não precisa do {}
            if (hora < 12)
                Console.WriteLine("Bom dia!");
            else if (hora < 18)
                Console.WriteLine("Boa tarde!");
            else
                Console.WriteLine("Boa noite!");
        }
    }
}
