using System;

namespace ExerciciosAula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio01();
        }

        static void Exercicio01()
        {
            /*
            Crie um algoritmo no qual o usuário/aluno deverá informar informar seu nome e quatro notas. O programama deverá calcular sua média e informar se o aluno foi aprovado ou não. O número seis é o valor mínimo para aprovação.
            */

            int nota1, nota2, nota3, nota4, media;

            Console.WriteLine("1ª nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2ª nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3ª nota: ");
            nota3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4ª nota: ");
            nota4 = Convert.ToInt32(Console.ReadLine());
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("A idade média do aluno é: " + media); 

            if (media >= 6)
            {
                Console.WriteLine("Aluno Aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado!");
            }


        }
    }
}
