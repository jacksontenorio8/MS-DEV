using System;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Representação do mundo real.

            //CLASSE / OBJETO => Físico / Abstrato.

            //OO = POO = Programação Orientada a Objeto.

            //Facilita o nosso entendimento, dividindo um programa em pequenas partes.

            

            //Uma Classe possui:

            //propriedade (atribuições) / características.
            //métodos (ações)
            //eventos (o que é feito durante a ação)


            //POO - Programação Orientada a Objeto.

            //4 - PILARES OO

            //1º - PILAR DO ENCAPSULAMENTO
            //AGRUPAR O QUE FAZ SENTIDO ESTAR JUNTO

            //2º - PILAR DA ABISTRAÇÃO
            //ATO DE ESCONDER OS DETALHES

            //3º - PILAR DA HERANÇA
            //CAPACIDADE DE UM OBJETO HERDAR, PROPRIEDADES, METODOS E EVENTOS E OUTRO OBJETO.

            //4º - POLIMORFISMO - QUANDO UM MÉTODO PODE SER EXECUTADO DE FORMAS DIFRENTES, EX(CLASS, ANIMAL COM O MÉTODO FALAR )


            //instanciar uma classe.

            Carro fusca = new Carro();//Cópia o objeto carro e instância na memoria.

            fusca.placa = "aaa000";
            fusca.LigarSeta();

            Moto novaMoto = new Moto();
            novaMoto.
        }

        

        class Carro 
        {

            //todas as variáveis se tornam propriedades.

            //niveis
            //public = publico
            //private = privado

            public string placa;
            public string chassi;
            public string cor;
            public string peso;

            //todas as funções se tornam métodos

            //nível de acesso.
            public void Andar()
            {
                ConsultarQuantidadeCombustivel();
            }

            public void Buzinar()
            {

            }

            private void AbrirPortaMala()
            {

            }


        }

        class Moto : Carro
        {
            public string guidao;
        }

        static void MaiorNumero()
        {

            //Criar um programa para ler três números inteiros e mostrar na tela o maior deles.

            int n1, n2, n3;

            Console.WriteLine("Digite três números inteiros:");

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("O número maior é: " + resultado);

            //&& -> as duas condiçoes devem ser verdadeiras.

            //F9 = ADICIONA UM DEBUG (BREAK POINT).
            //F11 = ENTRA NA FUNÇÃO
            //F10 = EXECUTA LINHA POR LINHA
            //SHIFT + F9 = EXECUTA O CODIGO SELECIONADO
            //F5 = EXECUTA O CODIGO ATÉ O FINAL OU ATÉ O PROXIMO BREAKPOINT


            //static vamos entender que a funcao princiap Main é static entao vamos manter para ter comunicação.

            // int =  a funcao maior vai retornar um tipo int.
            //Maior = nome da funcao.

            // () = significa que a funcao nao vai receber nenhum parametro.

            //() 
        }

        static int Maior(int n1, int n2, int n3)
        {
            int maior_numero;

            if (n1 > n2 && n1 > n3)
            {
                maior_numero = n1;
            }
            else if (n2 > n3)
            {
                maior_numero = n2;
            }
            else
            {
                maior_numero = n3;
            }

            //retorno da funcao;
            return maior_numero;

        }
    }
}
