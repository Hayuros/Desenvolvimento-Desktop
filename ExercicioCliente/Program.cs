using System;
using System.Windows.Forms;
using System.Drawing;
using TelaCliente;
using TelaLocacao;
using TelaVeiculoLeve;
using TelaVeiculoPesado;
using View.Biblio;

namespace ExercicioCliente
{
    public class Program : Form
    {
        BiblioButton btnCadastraCliente;
        BiblioButton btnCadastraLocacao;
        BiblioButton btnCadastraVeiculoLeve;
        BiblioButton btnCadastraVeiculoPesado;
        BiblioButton btnEditaCliente;
        BiblioButton btnEditaLocacao;
        BiblioButton btnEditaVeiculoLeve;
        BiblioButton btnEditaVeiculoPesado;
        BiblioButton btnExcluiCliente;
        BiblioButton btnExcluiLocacao;
        BiblioButton btnExcluiVeiculoLeve;
        BiblioButton btnExcluiVeiculoPesado;
        BiblioButton btnAtualizaCliente;
        BiblioButton btnAtualizaVeiculoLeve;
        BiblioButton btnAtualizaVeiculoPesado;

        BiblioLabel lbTextoCLiente;
        BiblioLabel lbTextoLocacao;
        BiblioLabel lbTextoVeiculoLeve;
        BiblioLabel lbTextoVeiculoPesado;
       
        public static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }
        public Program()
        {
            btnCadastraCliente = new BiblioButton(
                Text = "Cadastrar Cliente",
                Location = new Point(5, 26),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCadastraCliente.Click += new EventHandler(this.btnCadastraClienteClick);

            btnEditaCliente = new BiblioButton(
                Text = "Listar Cliente",
                Location = new Point(80, 26),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnEditaCliente.Click += new EventHandler(this.btnEditaClienteClick);

            btnExcluiCliente = new BiblioButton(
                Text = "Excluir Cliente",
                Location = new Point(155, 26),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnExcluiCliente.Click += new EventHandler(this.btnExcluiClienteClick);

            btnAtualizaCliente = new BiblioButton(
                Text = "Atualizar Cliente",
                Location = new Point(230, 26),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnAtualizaCliente.Click += new EventHandler(this.btnAtualizaClienteClick);
        
            btnCadastraLocacao = new BiblioButton(
                Text = "Cadastrar Locação",
                Location = new Point(5, 76),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCadastraLocacao.Click += new EventHandler(this.btnCadastraLocacaoClick);

            btnEditaLocacao = new BiblioButton(
                Text = "Listar Locação",
                Location = new Point(80, 76),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnEditaLocacao.Click += new EventHandler(this.btnEditaLocacaoClick);

            btnExcluiLocacao = new BiblioButton(
                Text = "Excluir Locação",
                Location = new Point(155, 76),
                Size = new Size(75, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnExcluiLocacao.Click += new EventHandler(this.btnExcluiLocacaoClick);
            
            btnCadastraVeiculoLeve = new BiblioButton(
                Text = "Cadastrar Veículo Leve",
                Location = new Point(5, 126),
                Size = new Size(100, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCadastraVeiculoLeve.Click += new EventHandler(this.btnCadastraVeiculoLeveCLick);

            btnEditaVeiculoLeve = new BiblioButton(
                Text = "Listar Veículo Leve",
                Location = new Point(105, 126),
                Size = new Size(100, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnEditaVeiculoLeve.Click += new EventHandler(this.btnEditaVeiculoLeveClick);

            btnExcluiVeiculoLeve = new BiblioButton(
                Text = "Excluir Veículo Leve",
                Location = new Point(205, 126),
                Size = new Size(100, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnExcluiVeiculoLeve.Click += new EventHandler(this.btnExcluiVeiculoLeveClick);

            btnAtualizaVeiculoLeve = new BiblioButton(
                Text = "Atualizar Veículo Leve",
                Location = new Point(305, 126),
                Size = new Size(100, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnAtualizaVeiculoLeve.Click += new EventHandler(this.btnAtualizaVeiculoLeveClick);

            btnCadastraVeiculoPesado = new BiblioButton(
                Text = "Cadastrar Veículo Pesado",
                Location = new Point(5, 176),
                Size = new Size(105, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCadastraVeiculoPesado.Click += new EventHandler(this.btnCadastraVeiculoPesadoClick);

            btnEditaVeiculoPesado = new BiblioButton(
                Text = "Listar Veículo Pesado",
                Location = new Point(105, 176),
                Size = new Size(105, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnEditaVeiculoPesado.Click += new EventHandler(this.btnEditaVeiculoPesadoClick);

            btnExcluiVeiculoPesado = new BiblioButton(
                Text = "Excluir Veículo Pesado",
                Location = new Point(205, 176),
                Size = new Size(105, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnExcluiVeiculoPesado.Click += new EventHandler(this.btnExcluiVeiculoPesadoClick);

            btnAtualizaVeiculoPesado = new BiblioButton(
                Text = "Atualizar Veículo Pesado",
                Location = new Point(305, 176),
                Size = new Size(105, 30),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnAtualizaVeiculoPesado.Click += new EventHandler(this.btnAtualizaVeiculoPesadoClick);
            

            lbTextoCLiente = new BiblioLabel(
                Text = "----------Cliente----------",
                Location = new Point(80, 5),
                Font = new Font(this.Font, FontStyle.Bold)
            ) {
                Size = new Size(200, 30)
            };

            lbTextoLocacao = new BiblioLabel(
                Text = "----------Locação----------",
                Location = new Point(80, 57),
                Font = new Font(this.Font, FontStyle.Bold)
            ) {
                Size = new Size(200, 30)
            };

            lbTextoVeiculoLeve = new BiblioLabel(
                Text = "----------Veículo Leve----------",
                Location = new Point(110, 107),
                Font = new Font(this.Font, FontStyle.Bold)
            ) {
                Size = new Size(200, 30)
            };

            lbTextoVeiculoPesado = new BiblioLabel(
                Text = "----------Veículo Pesado----------",
                Location = new Point(110, 157),
                Font = new Font(this.Font, FontStyle.Bold)
            ) {
                Size = new Size(200, 30)
            };


            this.Controls.Add(btnCadastraCliente);
            this.Controls.Add(btnCadastraLocacao);
            this.Controls.Add(btnCadastraVeiculoLeve);
            this.Controls.Add(btnCadastraVeiculoPesado);
            this.Controls.Add(btnEditaCliente);
            this.Controls.Add(btnEditaLocacao);
            this.Controls.Add(btnEditaVeiculoLeve);
            this.Controls.Add(btnEditaVeiculoPesado);
            this.Controls.Add(btnExcluiCliente);
            this.Controls.Add(btnExcluiLocacao);
            this.Controls.Add(btnExcluiVeiculoLeve);
            this.Controls.Add(btnExcluiVeiculoPesado);
            this.Controls.Add(btnAtualizaCliente);
            this.Controls.Add(btnAtualizaVeiculoLeve);
            this.Controls.Add(btnAtualizaVeiculoPesado);
            this.Controls.Add(lbTextoCLiente);
            this.Controls.Add(lbTextoLocacao);
            this.Controls.Add(lbTextoVeiculoLeve);
            this.Controls.Add(lbTextoVeiculoPesado);

            this.Text = "Programa de Locação de Veículos";
            this.Size = new Size(430, 247);
            Application.Run(this);
            
        }

        private void btnCadastraClienteClick(object sender, EventArgs e) {
            Application.Run(new MenuCadastraCliente());
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
        private void btnEditaClienteClick(object sender, EventArgs e) {
            Application.Run(new MenuEditaCliente());
        }
        private void btnEditaLocacaoClick(object sender, EventArgs e) {
            Application.Run(new MenuEditaLocacao());
        }
        private void btnEditaVeiculoLeveClick(object sender, EventArgs e) {
            Application.Run(new MenuEditaVeiculoLeve());
        }
        private void btnEditaVeiculoPesadoClick(object sender, EventArgs e) {
            Application.Run(new MenuEditaVeiculoPesado());
        }
        private void btnExcluiClienteClick(object sender, EventArgs e) {
            Application.Run(new MenuExcluiCliente());
        }
        private void btnExcluiLocacaoClick(object sender, EventArgs e) {
            Application.Run(new MenuExcluiLocacao());
        }
        private void btnExcluiVeiculoLeveClick(object sender, EventArgs e) {
            Application.Run(new MenuExcluiVeiculoLeve());
        }
        private void btnExcluiVeiculoPesadoClick(object sender, EventArgs e) {
            Application.Run(new MenuExcluiVeiculoPesado());
        }
        private void btnAtualizaClienteClick(object sender, EventArgs e) {
            Application.Run(new MenuAtualizaCliente());
        }
        private void btnAtualizaVeiculoLeveClick(object sender, EventArgs e) {
            Application.Run(new MenuAtualizaVeiculoLeve());
        }
        private void btnAtualizaVeiculoPesadoClick(object sender, EventArgs e) {
            Application.Run(new MenuAtualizaVeiculoPesado());
        }
    }
}