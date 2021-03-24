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
                Console.WriteLine("[3] - Cadastrar Veículos.");
                Console.WriteLine("[4] - Listar Veículos.");
                Console.WriteLine("[5] - Listar Veículos.");
                Console.WriteLine("[6] - Listar Veículos.");
                Console.WriteLine("[7] - Listar Veículos.");
                Console.WriteLine("[8] - Listar Veículos.");
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
                        // // case 3: {
                        // //     Model.VeiculoPesado.CriarVeiculoPesado();
                        // //     break;
                        // // }
                        // // case 4: {
                        // //     Model.VeiculoPesado.ListarVeiculoPesado();
                        // //     break;
                        // // }
                        // case 5: {
                            
                        //     break;
                        // } 
                        // case 6: {
                        //     break;
                        // }
                        // case 7: {
                        //     break;
                        // }
                        // case 8: {
                        //     break;
                        // }
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
