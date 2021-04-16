using System;
using System.Windows.Forms;
using System.Drawing;

namespace TelaVeiculoLeve
{
    public class MenuCadastraVeiculoLeve : Form{
        Button btnCadastra;
        Button btnCancela;
        
        Label lbMarca;
        Label lbModelo;
        Label lbAnoVeiculo;
        Label lbPreco;
        Label lbCor;

        TextBox tbMarca;
        TextBox tbModelo;
        TextBox tbAnoVeiculo;
        TextBox tbPreco;
        TextBox tbCor;
        public MenuCadastraVeiculoLeve() {           

            btnCadastra = new Button() {
                Text = "Cadastrar",
                Location = new Point(30, 160),
                BackColor = System.Drawing.Color.Green
            };
            btnCadastra.Click += new EventHandler(this.btnCadastraClick);
            btnCancela = new Button() {
                Text = "Cancelar",
                Location = new Point(110 , 160),
                BackColor = System.Drawing.Color.Red
            };
            btnCancela.Click += new EventHandler(this.btnCancelaClick);
            
            lbMarca = new Label() {
                Text = "Marca",
                Location = new Point(5, 10)
            };
            lbModelo = new Label() {
                Text = "Modelo",
                Location = new Point(5, 40)
            };
            lbAnoVeiculo = new Label() {
                Text = "Ano do Veiculo",
                Location = new Point(5, 70)
            };
            lbPreco = new Label() {
                Text = "Preco",
                Location = new Point(5,  100)
            };
            lbCor = new Label() {
                Text = "Cor",
                Location = new Point(5, 130)
            };

            tbMarca = new TextBox() {
                Location = new Point(105, 10),
                Size = new Size(100, 10)
            };
            tbModelo = new TextBox() {
                Location = new Point(105, 40),
                Size = new Size(100, 10)
            };
            tbAnoVeiculo = new TextBox() {
                Location = new Point(105, 70),
                Size = new Size(100, 10)
            };
            tbPreco = new TextBox() {
                Location = new Point(105,  100),
                Size = new Size(100, 10)
            };
            tbCor = new TextBox() {
                Location = new Point(105, 130),
                Size = new Size(100, 10)
            };


            this.Controls.Add(btnCadastra);
            this.Controls.Add(btnCancela);
            this.Controls.Add(lbMarca);
            this.Controls.Add(lbModelo);
            this.Controls.Add(lbAnoVeiculo);
            this.Controls.Add(lbPreco);
            this.Controls.Add(lbCor);
            this.Controls.Add(tbMarca);
            this.Controls.Add(tbModelo);
            this.Controls.Add(tbAnoVeiculo);
            this.Controls.Add(tbPreco);
            this.Controls.Add(tbCor);

            this.Text = "Cadastro de Veículos Leves";
            this.Size = new Size(220, 220);
            Application.Run(this);
        }

        private void btnCadastraClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Cadastrar Veículo Leve?",
                "Cadastro de Veículo Leve",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Cadastro efetuado com Sucesso!");
            } else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Cadastro Cancelado!");
            } else {
                MessageBox.Show("Opção Inválida");
            }
            this.Close();
        }
        private void btnCancelaClick(object sender, EventArgs e) {
            this.Close();
        }
    }
}