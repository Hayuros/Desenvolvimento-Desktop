using System;
using System.Collections.Generic;

namespace View
{
    public static class Cliente
    {
        
        public static void CriarCliente()
        {
            Console.WriteLine("\nCadastro de Clientes!");
            Console.WriteLine("\nInforme o seu nome.");
            string Nome = Console.ReadLine();
            Console.WriteLine("\nInforme o seu aniversário.");
            string Aniversario = Console.ReadLine();
            Console.WriteLine("\nInforme o seu CPF.");
            string Identificacao = Console.ReadLine();
            Console.WriteLine("\nInforme a quantidade de dias de retorno.");
            string DiasRetorno =Console.ReadLine();
            try
            {
                Controller.Cliente.CriarCliente(Nome, Aniversario, Identificacao, DiasRetorno);
            }
            catch (Exception e)
            {
                Console.WriteLine ($"As Informações digitadas estão incorretas: {e.Message}");
            }
        } //Término do programa de cadastro de clientes.

        public static void ListaCliente()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("\nListagem de Clientes");
            Console.WriteLine("*************************************");
            foreach (Model.Cliente cliente in Controller.Cliente.ListaCliente())
            {
                Console.WriteLine("=====================================");
                Console.WriteLine(cliente);
            }
            Console.WriteLine("=====================================");
        }//Término do programa de listagem dos clientes.
    } //Término da classe cliente.

   
} //Término do namespace.
