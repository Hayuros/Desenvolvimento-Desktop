using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{
    public class Locacao
    {
        public static Model.Locacao CriarLocacao(
            string IdCliente,
            string StringDataLocacao,
            List<Model.VeiculoLeve> veiculosLeves,
            List<Model.VeiculoPesado> veiculosPesados
        )
        {
            Model.Cliente clientes = Controller.Cliente.GetCliente(Convert.ToInt32(IdCliente));

            DateTime DataLocacao;

            try
            {
                DataLocacao = Convert.ToDateTime(StringDataLocacao);
            }
            catch (System.Exception)
            {
                DataLocacao = DateTime.Now;
            }

            if (DataLocacao > DateTime.Now)
            {
                throw new Exception("A Data de Locação não pode ser maior do que a data atual");
            }

            return new Model.Locacao(clientes, DataLocacao, veiculosLeves, veiculosPesados);
        }

        public static IEnumerable<Model.Locacao> GetLocacoes()
        {
            return Model.Locacao.GetLocacoes();
        }

        public static Model.Locacao AtualizarLocacao(
            Model.Locacao locacao,
            string opcao,
            string valor
        ) {
            int campo = Convert.ToInt32(opcao);
            switch (campo)
            {
                case 1: {
                    return Model.Locacao.AtualizarLocacao(locacao, campo, valor);
                }
                case 2: {
                    return Model.Locacao.AtualizarLocacao(locacao, campo, valor);
                }
                case 3: {
                    return Model.Locacao.AtualizarLocacao(locacao, campo, valor);
                }
                default: {
                    throw new Exception("Operação Inválida");

                }
            }
        }

        public static void ExcluirLocacao(string StringId) {
            int Id = Convert.ToInt32(StringId);
            try
            {
                Model.Locacao.ExcluirLocacao(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Está exclusão não foi permitida/Id Inválido." +e.Message);
            }
        }
    }//Término da classe Locação.
}
