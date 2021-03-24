using System.Collections.Generic;
using Model;

namespace Repository
{
    public class Context 
    {
        public static readonly List<Cliente> clientes = new ();
        public static readonly List<VeiculoPesado> veiculosPesados = new ();
        public static readonly List<VeiculoLeve> veiculosLeves = new ();
        public static readonly List<Locacao> locacoes = new ();
        public static readonly List<LocacaoVeiculoPesado> locacoesVeiculosPesados = new ();
        public static readonly List<LocacaoVeiculoLeve> locacoesVeiculosLeves = new ();

    }
}