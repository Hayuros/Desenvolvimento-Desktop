using System;
using System.Windows.Forms;
using System.Drawing;
using TelaCLiente;

namespace ExercicioCliente
{
    public class Program : Form
    {
        Button btnCadastrarCliente;
        public static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }
        public Program()
        {
            btnCadastrarCliente= new Button() {
                Text = "Cadastrar Cliente",
                Location = new Point(30, 30),
                Size = new Size(75, 30),
            };
            btnCadastrarCliente.Click += new EventHandler(this.btnCadastrarClienteClick);

            this.Controls.Add(btnCadastrarCliente);

            this.Size = new Size(150, 100);
            Application.Run(this);
            
        }

        private void btnCadastrarClienteClick(object sender, EventArgs e) {
            Application.Run(new MenuCadastraCLiente());
        }
    }
}