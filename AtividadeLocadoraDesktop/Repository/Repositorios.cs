using System.Collections.Generic;
using Model;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Context : DbContext
    {
        public DbSet<Cliente> clientes { set; get; }
        public DbSet<VeiculoPesado> veiculosPesados { set; get; }
        public DbSet<VeiculoLeve> veiculosLeves { set; get; }
        public DbSet<Locacao> locacoes { set; get; }
        public DbSet<LocacaoVeiculoPesado> locacoesVeiculosPesados { set; get; }
        public DbSet<LocacaoVeiculoLeve> locacoesVeiculosLeves { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql("Server=localhost;User Id=root;Database=locadora");

    }
}