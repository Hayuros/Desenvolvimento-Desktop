using System;
using System.Collections.Generic;

namespace Controller
{
    public static class Cliente
    {
        public static void CriarCliente(
            string Id,
            string Nome,
            string Aniversario,
            string Identificacao,
            string DiasRetorno
        )
        {
            new Model.Cliente(Convert.ToInt32(Id),
                Nome,
                Aniversario,
                Identificacao,
                Convert.ToInt32(DiasRetorno));
        }
    }//Término da classe cliente.
}
