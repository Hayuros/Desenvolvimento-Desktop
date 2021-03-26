using System;
using System.Collections.Generic;

namespace View
{
    public class VeiculoPesado
    {
        public static void CriarVeiculoPesado()
        {
            Console.WriteLine("Digite a Marca do Veículo");
            string Marca = Console.ReadLine();
            Console.WriteLine("Digite o Modelo do Veículo");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Digite o Ano do Veículo");
            string Ano = Console.ReadLine();
            Console.WriteLine("Digite o Preço do Veículo");
            string Preco = Console.ReadLine();
            Console.WriteLine("Digite as Restrições do Veículo");
            string Restricoes = Console.ReadLine();

            Controller.VeiculoPesado.CriarVeiculoPesado(Marca, Modelo, Ano, Preco, Restricoes);
        }

        public static void ListaVeiculosPesados()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("\nListagem de Veículos Pesados");
            Console.WriteLine("*************************************");
            foreach (Model.VeiculoPesado veiculo in Controller.VeiculoPesado.ListaVeiculoPesado())
            {
                Console.WriteLine("===========================");
                Console.WriteLine(veiculo);
            }
            Console.WriteLine("===========================");
        }
    }
}