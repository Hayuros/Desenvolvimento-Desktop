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
            List<Model.VeiculoPesado> veiculosPesados,
            List<Model.VeiculoLeve> veiculosLeves
        )
        {
           Model.Cliente clients = Controller.Cliente.GetCliente(Convert.ToInt32(IdCliente));
        
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
                throw new Exception ("A Data de Locação não pode ser maior do que a data atual");
            }

            return new Model.Locacao (Cliente, DataLocacao, veiculosLeves, veiculosPesados);
        }

        public static IEnumerable<Model.Locacao> GetLocacoes() {
            return Model.Locacao.GetLocacoes();
        }
    }//Término da classe Locação.
}
