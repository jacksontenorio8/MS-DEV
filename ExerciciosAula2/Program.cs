using System;

namespace ExerciciosAula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio01();
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

            Console.WriteLine("Produtos:\n" + produto1 +  ", cujo o preço é $ " + preco1 +",00\n" + produto2 + ", cujo o preço é $ " + preco2Total +",20\n" +"Registro: " + idade + " anos de idade," + " código " + codigo + " e gênero " + genero + "\n" +"Media com oito casas decimais: " + media +"00\n");
            Console.WriteLine(String.Format("Arredondado (três casas decimais): {0:F}", 53.234567));
        

        }
    }
}
