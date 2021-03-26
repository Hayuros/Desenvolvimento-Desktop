using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class VeiculoLeve : Veiculo
    {
        public int Id { set; get; }
        public string Cor { set; get; }

        public VeiculoLeve(
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Cor
        ) : base(Marca, Modelo, Ano, Preco)
        {
            this.Cor = Cor;

            Context DB = new Context();
            DB.veiculosLeves.Add(this);
            DB.SaveChanges();
        }

        public override string ToString()
        {
            return "\nId: " + this.Id +
                    "\n" + base.ToString() +
                    "\nCor: " + this.Cor;
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
            VeiculoLeve veiculoLeve = (VeiculoLeve)obj;
            return this.GetHashCode() == veiculoLeve.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id);
        }

        public static IEnumerable<Model.VeiculoLeve> GetVeiculoLeve()
        {
            Context DB = new Context();
            return from VeiculoLeve in DB.veiculosLeves select VeiculoLeve;
        }

        public static int GetCount()
        {
            return GetVeiculoLeve().Count();
        }

        public static VeiculoLeve GetVeiculoLeve(int Id)
        {
            Context DB = new Context();
            return (
                from VeiculoLeve in DB.veiculosLeves
                where VeiculoLeve.Id == Id
                select VeiculoLeve
            ).First();
        }
    }
}