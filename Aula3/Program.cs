using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para executar basta tirar o comentário da função desejadas
            //POR EXEMPLO: Abaixo vai ser executado apenas o operadorLogico.
            
            //OperadorLogico();
            //EntradaDeDados();
            SaidaDeDados();
        }

        static void OperadorLogico()
        {
            //OPERADOR LÓGICO

            // CONDIÇÃO E = && 

            // A PRIMEIRA CONDIÇÃO TEM QUE SER VERDADEIRA E A SEGUNDA TAMBÉM

            bool analise = 2 > 3 && 4 != 5;

            // NÃO (FALSE)

            // TRUE - TRUE

            bool analise2 = !(2 > 3) && 4 != 5;

            //Console.WriteLine(analise);
            //Console.WriteLine(analise2);

            String nome = "Jackson";
            String nome2 = "Tenorio";

            //  nome JACKSON não é igual a Tenorio

            bool nomeVerdade = (nome == "Jackson");
           
            Console.WriteLine(nomeVerdade); //TRUE

            bool nomeVerdade1 = (nome2 == "Tenorio");

            Console.WriteLine(nomeVerdade1); //TRUE

            //&& -> todas as condições devem ser TRUE.
            bool nomeVerdade2 = (nome == "Jackson" && nome == "Tenorio");
            Console.WriteLine("Testar aqui: " + nomeVerdade2); //FALSE.

            bool nomeVerdade3 = (nome != nome2);
            Console.WriteLine(nomeVerdade3);

            // || OU -> uma das condições deve ser TRUE.

            bool nomeVerdade4 = (nome == "Jackson" || nome == "Tenorio");
            Console.WriteLine(nomeVerdade4);

        }
        static void EntradaDeDados()
        {
            //ENTRADA DE DADOS.

            Console.WriteLine("Digite seu nome: ");

            // Console.ReadLine(); -> O PROGRAMA VAI LER O QUE FOI DIGITADO NO TECLADO E AGUARDAR A TECLA ENTER.

            // leitura da linha que o usuário digitou.
            string usuario = Console.ReadLine(); //Jackson
            Console.WriteLine("O nome informado foi: " + usuario);
        }
        static void SaidaDeDados()
        {
            //SAÍDA DE DADOS.

            int idade = 34;
            double saldo = 279.97;
            string nome = "Jackson";
            string nome1 = "Tenorio";

            //PLACEHOUDER - lugar para colocar a variável.
            //{0} - posição.

            // Jackson tem 34 anos e tem saldo igual a 279.97 reais.
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais.", nome, idade, saldo);

            //interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo + " reais.");

            Console.WriteLine(saldo);

            //convertendo int para string.
            Console.WriteLine(saldo.ToString("F2")); //deixa com duas casas e arredonda para cima

            //convertendo int para string.
            Console.WriteLine(saldo.ToString("F3")); //deixa com três casas e arredonda para cima
        }
    }
}
