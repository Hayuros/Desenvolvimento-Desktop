using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class LocacaoVeiculoPesado
    {
        public int Id { set; get; }
        public int IdLocacao { set; get; }
        public Locacao locacao { set; get; }
        public int IdVeiculoPesado { set; get; }
        public VeiculoPesado veiculoPesado { set; get; }
        public LocacaoVeiculoPesado()
        {

        }
        public LocacaoVeiculoPesado(
            Locacao locacao,
            VeiculoPesado veiculoPesado
        )
        {
            this.Id = Id;
            this.IdLocacao = locacao.Id;
            this.locacao = locacao;
            this.IdVeiculoPesado = veiculoPesado.Id;
            this.veiculoPesado = veiculoPesado;

            Context DB = new Context();
            DB.locacoesVeiculosPesados.Add(this);
            DB.SaveChanges();
        }

        public static IEnumerable<Model.LocacaoVeiculoPesado> GetVeiculos(int IdLocacao)
        {
            Context DB = new Context();
            return from Veiculo in DB.locacoesVeiculosPesados where Veiculo.IdLocacao == IdLocacao select Veiculo;
        }

        public static double GetTotal(int IdLocacao)
        {
            Context DB = new Context();
            return (
                from Veiculo in DB.locacoesVeiculosPesados
                where Veiculo.IdLocacao == IdLocacao
                select Veiculo.veiculoPesado.Preco
            ).Sum();
        }

        public static int GetCount(int IdLocacao)
        {
            return GetVeiculos(IdLocacao).Count();
        }
    }
}