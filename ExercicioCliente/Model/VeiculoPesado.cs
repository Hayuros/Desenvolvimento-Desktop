using System;
using System.Collections.Generic;
namespace Model
{
    public class VeiculoPesado : Veiculo
    {
        string Restricoes { set; get; }

        public VeiculoPesado(
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Restricoes
        ) : base(Marca, Modelo, Ano, Preco)
        { 
            this.Restricoes = Restricoes;
        }

        public override string ToString()
        {
            return "Marca:" +base.Marca+
            "Modelo:" +base.Modelo+
            "Ano:" +base.Ano+
            "Preço:"+base.Preco+
            "Restriçoes: "+this.Restricoes;
        }
    }
}
