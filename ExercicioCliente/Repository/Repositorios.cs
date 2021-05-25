using System.Collections.Generic;
using Model;
using System;
using Fake;
namespace Repository
{
    public class Context
    {
        public static DBFake<Cliente> clientes = new DBFake<Cliente>();
        public static DBFake<VeiculoPesado> veiculosPesados = new DBFake<VeiculoPesado>();
        public static DBFake<VeiculoLeve> veiculosLeves = new DBFake<VeiculoLeve>();
        public static DBFake<Locacao> locacoes = new DBFake<Locacao>();
        public static DBFake<LocacaoVeiculoPesado> locacoesVeiculosPesados = new DBFake<LocacaoVeiculoPesado>();
        public static DBFake<LocacaoVeiculoLeve> locacoesVeiculosLeves = new DBFake<LocacaoVeiculoLeve>();

        public void SaveChanges() {

        }

        public Context() {
            
        }
    }
}