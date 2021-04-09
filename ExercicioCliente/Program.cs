using System;
using System.Windows.Forms;
using System.Drawing;

namespace ExercicioCliente
{
    public class Program
    {
        public static void Main() 
        { 
            Form menuPrincipal = new Form() {
                Size = new Size(200, 200)
            };
            Button cadastrarCliente = new Button() {
                Text = "Cadastrar Cliente",
                Location = new Point(50, 30),
                Size = new Size(75, 30)
            };

            menuPrincipal.Controls.Add(cadastrarCliente);
            Application.EnableVisualStyles();
            Application.Run(menuPrincipal);
        }
    }
}