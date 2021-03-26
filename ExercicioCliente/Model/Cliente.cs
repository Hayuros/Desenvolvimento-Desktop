using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class Cliente
    {
        public int Id { set; get; } // Identificador Único (ID)

        public string Nome { set; get; } // Nome

        public DateTime Aniversario { set; get; } // Data de Nascimento

        public string Identificacao { set; get; } // C.P.F.

        public int DiasRetorno { set; get; } // Dias para Devolução

        public Cliente(string Nome,
            DateTime Aniversario,
            string Identificacao,
            int DiasRetorno)
        {
            this.Nome = Nome;
            this.Aniversario = Aniversario;
            this.Identificacao = Identificacao;
            this.DiasRetorno = DiasRetorno;
            Context DB = new Context();

            DB.clientes.Add(this);
            DB.SaveChanges();
        }

        public override string ToString()
        {
            return String.Format("Id: {0}\nNome: {1}\nData de Nascimento {2:d}\nDias para Devolução: {3}\nQuantidade de Locações: {4}",
                this.Id,
                this.Nome,
                this.Aniversario,
                this.DiasRetorno,
                Locacao.GetCount(this.Id)
            );
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
            Cliente cliente = (Cliente)obj;
            return this.GetHashCode() == cliente.GetHashCode();
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ this.Id.GetHashCode();
                return hash;
            }
        }

        public static IEnumerable<Cliente> GetClientes()
        {
            Context DB = new Context();
            return from cliente in DB.clientes select cliente;
        }

        public static int GetConta()
        {
            return GetClientes().Count();
        }

        public static void AddCliente(Cliente cliente)
        {
            Context DB = new Context();
            DB.clientes.Add(cliente);
        }

        public static Cliente GetCliente(int Id)
        {
            Context DB = new Context();
            IEnumerable<Cliente> query = from cliente in DB.clientes where cliente.Id == Id select cliente;

            return query.First();

        }
    } //Término da classe cliente.
}
