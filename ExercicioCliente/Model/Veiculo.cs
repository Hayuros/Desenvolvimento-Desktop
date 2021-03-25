using System;

namespace Model
{
    public class Veiculo
    {
        public string Marca { set; get; }

        public string Modelo { set; get; }

        public int Ano { set; get; }

        public double Preco { set; get; }

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
            "Preço:" + String.Format("{0:c}", this.Preco);
        }
    }
}
