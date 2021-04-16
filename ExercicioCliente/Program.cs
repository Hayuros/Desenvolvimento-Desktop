using System;
using System.Windows.Forms;
using System.Drawing;
using TelaCLiente;
using TelaLocacao;
using TelaVeiculoLeve;
using TelaVeiculoPesado;

namespace ExercicioCliente
{
    public class Program : Form
    {
        Button btnCadastrarCliente;
        Button btnCadastraLocacao;
        Button btnCadastraVeiculoLeve;
        Button btnCadastraVeiculoPesado;
        public static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }
        public Program()
        {
            btnCadastrarCliente = new Button() {
                Text = "Cadastrar Cliente",
                Location = new Point(30, 10),
                Size = new Size(75, 30)
            };
            btnCadastrarCliente.Click += new EventHandler(this.btnCadastrarClienteClick);

            btnCadastraLocacao = new Button() {
                Text = "Cadastrar Locação",
                Location = new Point(30, 50),
                Size = new Size(75, 30)
            };
            btnCadastraLocacao.Click += new EventHandler(this.btnCadastraLocacaoClick);

            btnCadastraVeiculoLeve = new Button() {
                Text = "Cadastrar Veículo Leve",
                Location = new Point(20, 90),
                Size = new Size(100, 30)
            };
            btnCadastraVeiculoLeve.Click += new EventHandler(this.btnCadastraVeiculoLeveCLick);

            btnCadastraVeiculoPesado = new Button() {
                Text = "Cadastrar Veículo Pesado",
                Location = new Point(20, 130),
                Size = new Size(105, 30)
            };
            btnCadastraVeiculoPesado.Click += new EventHandler(this.btnCadastraVeiculoPesadoClick);

            this.Controls.Add(btnCadastrarCliente);
            this.Controls.Add(btnCadastraLocacao);
            this.Controls.Add(btnCadastraVeiculoLeve);
            this.Controls.Add(btnCadastraVeiculoPesado);

            this.Text = "Programa de Locação de Veículos";
            this.Size = new Size(150, 200);
            Application.Run(this);
            
        }

        private void btnCadastrarClienteClick(object sender, EventArgs e) {
            Application.Run(new MenuCadastraCLiente());
        }
        private void btnCadastraLocacaoClick(object sender, EventArgs e) {
            Application.Run(new MenuCadastraLocacao());
        }
        private void btnCadastraVeiculoLeveCLick(object sender, EventArgs e) {
            Application.Run(new MenuCadastraVeiculoLeve());
        }
        private void btnCadastraVeiculoPesadoClick(object sender, EventArgs e) {
            Application.Run(new MenuCadastraVeiculoPesado());
        }
    }
}