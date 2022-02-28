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
            //IFElseIf();
            //Switch();
            //SwitchCase();
            //While();
            DoWhile();
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

        static void Switch()
        {
            //SWITCH - chavear

            Console.WriteLine("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());

            switch (hora) //int, string
            {
                case < 12: Console.WriteLine("Bom dia!"); break;
                case < 18: Console.WriteLine("Boa tarde!"); break;
                default: Console.WriteLine("Boa noite!"); break;
            }
        }
        static void SwitchCase()
        {
            int tempo = 0;
            char escolha;

            Console.WriteLine("Campinas/SP a Maceió/AL");
            Console.WriteLine("Escolha o transporte: [a]=Avião | [b]=Carro | [c]=Ônibus");

            escolha = char.Parse(Console.ReadLine().ToLower()); //.ToLower()-> O que o usuário digitar muda para minúsculo.

            switch (escolha)
            {
                case 'a': //Caso o valor da escolha for a.
                    tempo = 3;
                    break;
                
                case 'b':
                    tempo = 60;
                    break;
                case 'c':
                    tempo = 72;
                    break;

                default: 
                    tempo = -1;
                    break;
            }
            if (tempo < 0)
            {
                Console.WriteLine("Transporte indisponível");
            }
            else
            {
                Console.WriteLine("Para o transporte escolhido o tempo é: {0}", tempo);
            }
        }
        static void While()
        {
            //WHILE = ENQUANTO;
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;

            while (numero != 0) //enquanto a condicao for TRUE, FAÇA o bloco de codigo.
            {
                soma = soma + numero;
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("A soma dos valores é: {0}", soma);
            Console.ReadLine(); //Esperar enter para a sair;   
           
        }

        DoWhile()
        { 
            //DO WHILE 

            int numero = 45;

            do //faça
            {
                Console.WriteLine(numero);
                ++numero; //1 por vez
            }
            while (numero <= 50); //enquanto o número for menor que 50 FAÇA. 

            //OUTRO EXEMPLO DO WHILE

            do 
            {
                Console.WriteLine("Digitar número: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("O número digitado foi: {0}", numero);
            }
            while (numero != 10); 
        }
    }   
}
