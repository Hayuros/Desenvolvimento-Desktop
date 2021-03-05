using System;
using System.Collections.Generic;

namespace Model
{
    public class Cliente
    {
        private int Id { set; get; } // Identificador Único (ID)

        private string Nome { set; get; } // Nome

        private string Aniversario { set; get; } // Data de Nascimento

        private string Identificacao { set; get; } // C.P.F.

        private int DiasRetorno { set; get; } // Dias para Devolução

        private static List<Cliente> clientes = new List<Cliente>();

        public Cliente(
            int Id,
            string Nome,
            string Aniversario,
            string Identificacao,
            int DiasRetorno)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Aniversario = Aniversario;
            this.Identificacao = Identificacao;
            this.DiasRetorno = DiasRetorno;

            clientes.Add(this);
        }

        public static List<Cliente> GetClientes()
        {
            return clientes;
        }

        public override string ToString()
        {
            return "Id: " +this.Id+
            "Nome: " +this.Nome+
            "CPF: " +this.Identificacao+
            "Dias de retorno: " +this.DiasRetorno;
        }
    } //Término da classe cliente.
}
