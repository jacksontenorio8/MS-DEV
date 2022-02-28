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
            EntradaDeDados();
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
            //
        }
    }
}
