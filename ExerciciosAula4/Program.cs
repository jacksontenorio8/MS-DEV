using System;

namespace ExerciciosAula4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            Exercicio03();
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
        static void Exercicio02()
        {
            //CRIE UM ALGORITMO QUE LÊ 3 NÚMEROS INTEIROS E RETORNE QUAL É O MAIOR

            int numero=0, maior=0;

            Console.WriteLine("Digite o 1º número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            maior = numero;
            Console.WriteLine("Digite o 2º número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > maior) 
            {
                maior = numero;
            }

            Console.WriteLine("Digite o 3º número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > maior)
            {
                maior = numero;
            }

            Console.WriteLine("O maior número é: {0}", maior);
        }
        static void Exercicio03()
        {
            /*
                Uma empresa concederá um aumento de salário aos seus funcionários, variável de acordo com o cargo, conforme a tabela abaixo. Programa que lê o salário e o código do cargo de um funcionário e calcula o novo salário. Se o cargo do funcionário não estiver na tabela, ele recebe 40% de aumento.



                 Código           Cargo              Aumento

                    1              gerente             10%

                    2              engenheiro          20%

                    3              técnico             30%


                No final é mostrado o salário antigo e o novo salário.

            */
            double salario, novoSalario;
            int escolha;

            Console.WriteLine("Digite o valor do seu salário: ");
            salario = double.Parse(Console.ReadLine());
            

            Console.WriteLine("Escolha o cargo: [1]=gerente | [2]=engenheiro | [3]=técnico | [4]=outro");
            escolha = int.Parse(Console.ReadLine()); 
            if (escolha == 1)
            {
                novoSalario = salario + (salario * 0.1);
                Console.WriteLine("O salário anterior é de {0:F2} e o salária atual é de {1:F2}", salario, novoSalario);
            }

            else if (escolha == 2)
            {
                novoSalario = salario + (salario * 0.2);
                Console.WriteLine("O salário anterior é de {0:F2} e o salária atual é de {1:F2}", salario, novoSalario);
            }

            else if (escolha == 3)
            {
                novoSalario = salario + (salario * 0.3);
                Console.WriteLine("O salário anterior é de {0:F2} e o salária atual é de {1:F2}", salario, novoSalario);
            }

            else if (escolha == 4)
            {
                novoSalario = salario + (salario * 0.4);
                Console.WriteLine("O salário anterior é de {0:F2} e o salária atual é de {1:F2}", salario, novoSalario);
            }

            else
            {
                
                Console.WriteLine("ERRO!");
            }
        
            
        }
    }
}
