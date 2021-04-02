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
                Console.WriteLine("******************************************");
                Console.WriteLine("Faça sua Escolha");
                Console.WriteLine("[0] - Sair.");
                Console.WriteLine("[1] - Cadastrar Cliente.");
                Console.WriteLine("[2] - Listar Clientes.");
                Console.WriteLine("[3] - Atualizar Clientes.");
                Console.WriteLine("[4] - Excluir Clientes.");
                Console.WriteLine("[5] - Cadastrar Veículos Leves.");
                Console.WriteLine("[6] - Listar Veículos Leves.");
                Console.WriteLine("[7] - Atualizar Veículos Leves.");
                Console.WriteLine("[8] - Excluir Veículos Leves.");
                Console.WriteLine("[9] - Cadastrar Veículos Pesados.");
                Console.WriteLine("[10] - Listar Veículos Pesados.");
                Console.WriteLine("[11] - Atualizar Veículos Pesados.");
                Console.WriteLine("[12] - Excluir Veículos Pesados.");
                Console.WriteLine("[13] - Cadastrar Locações.");
                Console.WriteLine("[14] - Listar Locações.");
                Console.WriteLine("[15] - Atualizar Locações.");
                Console.WriteLine("[16] - Exlcuir Locações.");
                Console.WriteLine("******************************************");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        {
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
                    case 3: 
                        {
                            View.Cliente.AtualizarCliente();
                            break;
                        }
                    // case 4: 
                    //     {
                    //         View.Cliente.ExcluirCliente();
                    //         break;
                    //     }
                    // case 5:
                    //     {
                    //         View.VeiculoLeve.CriarVeiculoLeve();
                    //         break;
                    //     }
                    // case 6:
                    //     {
                    //         View.VeiculoLeve.ListaVeiculosLeves();
                    //         break;
                    //     }
                    // case 7: 
                    //     {
                    //         View.VeiculoLeve.AtualizarVeiculoLeve();
                    //         break;
                    //     }
                    // case 8: 
                    //     {
                    //         View.VeiculoLeve.ExcluirVeiculoLeve();
                    //         break;
                    //     }
                    // case 9:
                    //     {
                    //         View.VeiculoPesado.CriarVeiculoPesado();
                    //         break;
                    //     }
                    // case 10:
                    //     {
                    //         View.VeiculoPesado.ListaVeiculosPesados();
                    //         break;
                    //     }
                    // case 11: 
                    //     {
                    //         View.VeiculoPesado.AtualizarVeiculoPesado();
                    //         break;
                    //     }
                    // case 12: 
                    //     {
                    //         View.VeiculoPesado.ExcluirVeiculoPesado();
                    //         break;
                    //     }
                    // case 13:
                    //     {
                    //         View.Locacao.CriarLocacao();
                    //         break;
                    //     }
                    // case 14:
                    //     {
                    //         View.Locacao.ListarLocacoes();
                    //         break;
                    //     }
                    // case 15:
                    //     {
                    //         View.Locacao.AtualizarLocacoes();
                    //         break;
                    //     }
                    // case 16:
                    //     {
                    //         View.Locacao.ExcluirLocacoes();
                    //         break;
                    //     }
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