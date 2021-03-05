using System;
using System.Collections.Generic;

namespace View
{
    public class Cliente
    {
        
        public static void CriarCliente()
        {
            Console.WriteLine("\nCadastro de Clientes!");
            Console.WriteLine("\nInforme o seu Id.");
            string id = Console.ReadLine();
            Console.WriteLine("\nInforme o seu nome.");
            string nome = Console.ReadLine();
            Console.WriteLine("\nInforme o seu aniversário.");
            string aniversario = Console.ReadLine();
            Console.WriteLine("\nInforme o seu CPF.");
            string identificacao = Console.ReadLine();
            Console.WriteLine("\nInforme a quantidade de dias de retorno.");
            string diasRetorno =Console.ReadLine();

            Controller.Cliente.CriarCliente(id,
                nome,
                aniversario,
                identificacao,
                diasRetorno);
        } //Término do programa de cadastro de clientes.

        public static void ListaCliente()
        {
            Console.WriteLine("\nListagem de Clientes");
            foreach (Model.Cliente item in Model.Cliente.GetClientes())
            {
                Console.WriteLine(item);
            }
            
        }//Término do programa de listagem dos clientes.
    } //Término da classe cliente.

   
} //Término do namespace.
