using System;
using System.Globalization;

namespace ExerciciosAula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01();
            Exercicio02();
        }
        static void Exercicio01()
        {
            string produto1 = "Computador 1";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco2Total = preco2 - 0.5;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é ${1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é ${1:F2}", produto2, preco2);
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo,genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", media);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", media);
            Console.WriteLine("Separador decimal invariant culture: " + media.ToString("F3", CultureInfo.InvariantCulture));

        }
        static void Exercicio02()
        {
            //Elabore um algoritmo que receba e calcule a idade média de 5 alunos.
            int idade1, idade2, idade3, idade4, idade5, media;

            Console.WriteLine("Qual a idade do 1º aluno: ");
            idade1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a idade do 2º aluno: ");
            idade2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a idade do 3º aluno: ");
            idade3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a idade do 4º aluno: ");
            idade4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a idade do 5º aluno: ");
            idade5 = Convert.ToInt32(Console.ReadLine());
            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
            Console.WriteLine("A idade média dos alunos é: " + media); 

        }
       
    }
}
