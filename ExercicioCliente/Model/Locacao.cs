using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class Locacao
    {
        public int Id {set; get;}
        public int IdCliente {set; get;}
        public Cliente Cliente {set; get;}
        public DateTime DataLocacao {set; get;}

        public Locacao(Cliente cliente,
            DateTime DataLocacao,
            List<VeiculoLeve> VeiculosLeves,
            List<VeiculoPesado> VeiculosPesados
        ) {
            this.Id =Id;
            this.IdCliente =IdCliente;
            this.Cliente =Cliente;
            this.DataLocacao =DataLocacao; 

            foreach (VeiculoLeve veiculo in VeiculosLeves)
            {
                LocacaoVeiculoLeve locacaoVeiculoLeve = new LocacaoVeiculoLeve(this, veiculo);
            }

            foreach (VeiculoPesado veiculo in VeiculosPesados)
            {
                LocacaoVeiculoPesado locacaoVeiculoPesado = new LocacaoVeiculoPesado(this, veiculo);
            }

            Context.locacoes.Add(this);
        }

        public double GetValorLocacao() {
            double total = 0;

            foreach (LocacaoVeiculoLeve veiculo in LocacaoVeiculoLeve.GetVeiculos(this.Id))
            {
                total += veiculo.veiculoLeve.Preco;
            }

            total += LocacaoVeiculoPesado.GetTotal(this.Id);

            return total;
        }

        public DateTime GetDataRetorno() {
            int DiasRetorno = this.Cliente.DiasRetorno;

            return this.DataLocacao.AddDays(DiasRetorno);
        }

        public override string ToString()
        {
            string Print = String.Format (
                "Data da Locação: {0:d}\nData de Decolução: {1:d}\nValor: {2:c}\nCliente: {3}",
                this.DataLocacao,
                this.GetDataRetorno(),
                this.GetValorLocacao(),
                this.Cliente
            );

            //Printando na telas os veículos leves locados
            Print += "\nVeiculos Leves Locados: ";
            if (LocacaoVeiculoLeve.GetCount(this.Id) > 0)
            {
                foreach (LocacaoVeiculoLeve veiculo in LocacaoVeiculoLeve.GetVeiculos(this.Id))
                {
                    Print += "\n "+veiculo.veiculoLeve;
                }
            } else {
                Print += "\n Não Consta nada.";  
            }

            //Printando na tela os veículos pesados locados.
            Print += "\nVeiculos Pesados Locados: ";
            if (LocacaoVeiculoPesado.GetCount(this.Id) > 0)
            {
                foreach (LocacaoVeiculoPesado veiculo in LocacaoVeiculoPesado.GetVeiculos(this.Id))
                {
                    Print += "\n "+veiculo.veiculoPesado;
                }
            }  else {
                Print += "\n Não Consta nada.";  
            }

            return Print;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Locacao locacao = (Locacao) obj;
            return this.GetHashCode() == locacao.GetHashCode();
            
        }
        
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id);
        }

        public static IEnumerable<Locacao> GetLocacoes() {
            return from Locacao in Context.locacoes select Locacao;
        }

        public static int GetCount(int IdCliente) {
            return (from Locacao in Context.locacoes where Locacao.IdCliente == IdCliente select Locacao).Count();
        }
    }//Término da classe Locação.
}
