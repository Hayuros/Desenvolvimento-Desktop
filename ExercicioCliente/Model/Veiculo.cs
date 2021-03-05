using System;
using System.Collections.Generic;
namespace Model
{
    public class Veiculo
    {
        protected string Marca { set; get; }

        protected string Modelo { set; get; }

        protected int Ano { set; get; }

        protected double Preco { set; get; }

        protected Veiculo(string Marca, string Modelo, int Ano, double Preco)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Ano = Ano;
            this.Preco = Preco;
        }

        public override string ToString()
        {
            return "Marca:" + this.Marca +
            "Modelo:" + this.Modelo +
            "Ano:" + this.Ano + 
            "Preço:" + this.Preco;
        }
    }
}
