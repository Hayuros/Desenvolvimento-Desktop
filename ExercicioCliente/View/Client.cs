using System;
using System.Collections.Generic;

namespace View
{
    public class Client
    {
        private int id;

        private string name;

        private string birth;

        private string identification;

        private int returnDays;

        public static void CreateClient()
        {
            Console.WriteLine("\nCadastro de Clientes!");
            Console.WriteLine("\nInforme o seu Id.");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInforme o seu nome.");
            string name = Console.ReadLine();
            Console.WriteLine("\nInforme o seu aniversário.");
            string birth = Console.ReadLine();
            Console.WriteLine("\nInforme o seu CPF.");
            string identification = Console.ReadLine();
            Console.WriteLine("\nInforme a quantidade de dias de retorno.");
            int returnDays = Convert.ToInt32(Console.ReadLine());

            Controller
                .CreateClient(int id,
                string name,
                string birth,
                string identification,
                int returnDays);
        } //Término do programa de cadastro de clientes.

        public static void ListClient()
        {
            Console.WriteLine("\nListagem de Clientes");
            Model.Client.GetClients();
        }
    } //Término da classe client.

    public class Program
    {
        public static void Main(string[] args)
        {
            int opcao = 0;

            Console.WriteLine("Exercício do Cliente!");
            do
            {
                Console.WriteLine("\n\nFaça sua Esolha!");
                Console.WriteLine("\n[0] - Sair.");
                Console.WriteLine("\n[1] - Cadastrar Cliente.");
                Console.WriteLine("\n[2] - Listar Cliente.");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        {
                            Console
                                .WriteLine("\nObrigado por utilizar este programa!");
                            break;
                        }
                    case 1:
                        {
                            View.Client.CreateClient();
                            break;
                        }
                    case 2:
                        {
                            View.Client.ListClient();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nOpção Inválida!");
                            Console
                                .WriteLine("\nPor favor selecione uma opção válida");
                            break;
                        }
                }
            }
            while (opcao != 0);
        } //Término da main.
    } //Término da classe program.
} //Término do namespace.
