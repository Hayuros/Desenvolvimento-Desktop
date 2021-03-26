using System;
using System.Collections.Generic;

namespace View
{
    public class VeiculoLeve
    {
        public static void CriarVeiculoLeve()
        {
            Console.WriteLine("Digite a Marca do Veículo");
            string Marca = Console.ReadLine();
            Console.WriteLine("Digite o Modelo do Veículo");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Digite o Ano do Veículo");
            string Ano = Console.ReadLine();
            Console.WriteLine("Digite o Preço do Veículo");
            string Preco = Console.ReadLine();
            Console.WriteLine("Digite a Cor do Veículo");
            string Cor = Console.ReadLine();

            Controller.VeiculoLeve.CriarVeiculoLeve(Marca, Modelo, Ano, Preco, Cor);
        }

        public static void ListaVeiculosLeves()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("\nListagem de Veiculos Leves");
            Console.WriteLine("*************************************");
            foreach (Model.VeiculoLeve veiculo in Controller.VeiculoLeve.ListaVeiculoLeve())
            {
                Console.WriteLine("===========================");
                Console.WriteLine(veiculo);
            }
            Console.WriteLine("===========================");
        }
    }
}