using System;
using System.Collections.Generic;

namespace DevFitness.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome. ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite sua altura. ");
            var altura = Console.ReadLine();
            Console.WriteLine("Digite seu peso. ");
            var peso = Console.ReadLine();

            var listaRefeicoes = new List<Refeicao>();
           
            ExibirOpcoes();

            var opcao = Console.ReadLine();
            while (opcao != "0") { 
            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Nome: {nome}\nAltura: {altura}\nPeso: {peso}");
                    break;
                case "2":
                    Cadastrar(listaRefeicoes);
                    break;
                case "3":
                    ListarRefeicoes(listaRefeicoes);
                    break;
                default:
                    Console.WriteLine("Por favor, digite outra opção. ");
                    break;
            }
            Console.ReadLine();
            }
        }
        public static void ExibirOpcoes()
        {
            Console.WriteLine("---Seja bem vindo (a) ao DevFitness ---");
            Console.WriteLine("1- Exibir detalhes de usuário.");
            Console.WriteLine("2- Cadastrar nova refeição.");
            Console.WriteLine("3- Listar todas refeições.");
            Console.WriteLine("0- Finalizar aplicação.");
        }
        public static void Cadastrar(List<Refeicao> refeicoes)
        {
            Console.WriteLine("Digite a descrição da refeição. ");
            var descricao = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de calorias. ");
            var calorias = Console.ReadLine();

            if(int.TryParse(calorias, out int caloriasInt)){
                var refeicao = new Refeicao(descricao, caloriasInt);
                refeicoes.Add(refeicao);
                Console.WriteLine("Refeição adicionada com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de calorias inválido.");
            }
        }
        public static void ListarRefeicoes(List<Refeicao> refeicoes)
        {
            foreach(var refeicao in refeicoes)
            {
                refeicao.ImprimirMensagem();
            }
        }
    }
   
}
