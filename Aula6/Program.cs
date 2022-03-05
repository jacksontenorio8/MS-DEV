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


    }
}
