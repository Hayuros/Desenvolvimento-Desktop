using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class VeiculoPesado : Veiculo
    {
        public int Id { set; get; }
        public string Restricoes { set; get; }

        public VeiculoPesado(
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Restricoes
        ) : base(Marca, Modelo, Ano, Preco)
        {
            this.Restricoes = Restricoes;

            Context DB = new Context();
            DB.veiculosPesados.Add(this);
            DB.SaveChanges();
        }

        public override string ToString()
        {
            return "\nId: " + this.Id +
                    "\n" + base.ToString() +
                    "\nRestricoes: " + this.Restricoes;
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
            VeiculoPesado veiculoPesado = (VeiculoPesado)obj;
            return this.GetHashCode() == veiculoPesado.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id);
        }

        public static IEnumerable<Model.VeiculoPesado> GetVeiculoPesado()
        {
            Context DB = new Context();
            return from VeiculoPesado in DB.veiculosPesados select VeiculoPesado;
        }

        public static int GetCount()
        {
            return GetVeiculoPesado().Count();
        }

        public static VeiculoPesado GetVeiculoPesado(int Id)
        {
            Context DB = new Context();
            return (
                from VeiculoPesado in DB.veiculosPesados
                where VeiculoPesado.Id == Id
                select VeiculoPesado
            ).First();
        }

         public static VeiculoPesado AtualizarVeiculoPesado(
            VeiculoPesado veiculoPesado,
            int campo,
            string valor
        ) {
            switch (campo)
            {
                case 1: {
                    VeiculoPesado.Marca = valor;
                    break;
                }
                case 2: {
                    VeiculoPesado.Modelo = valor;
                    break;
                }
                case 3: {
                    VeiculoPesado.Ano = valor;
                    break;
                }
                case 4: {
                    VeiculoPesado.Preco = valor;
                    break;
                }
                case 5: {
                    veiculoPesado.Restricoes = valor;
                    break;
                }
                default: {
                    Console.WriteLine("Campo digitado não existente/não possível de auterações.");
                    break;
                }
                Context DB = new Context();
                DB.veiculosPesados.Update(VeiculoPesado);
                DB.SaveChanges();
                return VeiculoPesado;
            } 
        }

        public static VeiculoPesado ExcluirVeiculoPesado(int id) {
            VeiculoPesado veiculoPesado = GetVeiculoPesado(id);
            Context DB = new Context();
            DB.veiculosPesados.Remove(VeiculoPesado);
            DB.SaveChanges();
            return VeiculoPesado;
        }
    }
}