using System;

namespace ExercicioCliente
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int op = 0;
            Console.WriteLine("---------Programa da Locadora---------");
            do
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Faça sua Escolha");
                Console.WriteLine("[1] - Cadastrar Cliente.");
                Console.WriteLine("[2] - Listar Clientes.");
                Console.WriteLine("[3] - Cadastrar Veículos Leves.");
                Console.WriteLine("[4] - Listar Veículos Leves.");
                Console.WriteLine("[5] - Cadastrar Veículos Pesados.");
                Console.WriteLine("[6] - Listar Veículos Pesados.");
                Console.WriteLine("[7] - Cadastrar Locações.");
                Console.WriteLine("[8] - Listar Locações.");
                Console.WriteLine("[0] - Sair.");
                Console.WriteLine("*************************************");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0: {
                        Console.WriteLine("Até mais!");
                        break;
                    }
                    case 1:
                        {
                            View.Cliente.CriarCliente();
                            break;
                        }
                    case 2:
                        {
                            View.Cliente.ListaCliente();
                            break;
                        }
                        case 3: {
                            View.VeiculoLeve.CriarVeiculoLeve();
                            break;
                        }
                        case 4: {
                            View.VeiculoLeve.ListaVeiculosLeves();
                            break;
                        }
                        case 5: {
                            View.VeiculoPesado.CriarVeiculoPesado();
                            break;
                        } 
                        case 6: {
                            View.VeiculoPesado.ListaVeiculosPesados();
                            break;
                        }
                        case 7: {
                            View.Locacao.CriarLocacao();
                            break;
                        }
                        case 8: {
                            View.Locacao.ListarLocacoes();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção inválida!");
                            break;
                        }
                }
            }
            while (op != 0);
        }
    }
}
