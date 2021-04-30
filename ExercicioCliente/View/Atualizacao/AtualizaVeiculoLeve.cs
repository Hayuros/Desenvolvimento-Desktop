using System;
using System.Windows.Forms;
using System.Drawing;
using View.Biblio;

namespace TelaVeiculoLeve
{
    public class MenuAtualizaVeiculoLeve : Form{
        BiblioButtonAtualiza btnAtualiza;
        BiblioButtonCancela btnCancela;
        
        BiblioLabel lbMarca;
        BiblioLabel lbModelo;
        BiblioLabel lbAnoVeiculo;
        BiblioLabel lbPreco;
        BiblioLabel lbCor;

        BiblioTextBox tbMarca;
        BiblioTextBox tbModelo;
        BiblioTextBox tbAnoVeiculo;
        BiblioTextBox tbPreco;
        BiblioTextBox tbCor;
        public MenuAtualizaVeiculoLeve() {           

            btnAtualiza = new BiblioButtonAtualiza(
                Text = this.Text,
                Location = new Point(30, 160),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnAtualiza.Click += new EventHandler(this.btnAtualizaClick);
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110 , 160),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(this.btnCancelaClick);
            
            lbMarca = new BiblioLabel(
                Text = "Marca",
                Location = new Point(5, 10),
                Font = new Font(this.Font, FontStyle.Bold)    
            );

            lbModelo = new BiblioLabel(
                Text = "Modelo",
                Location = new Point(5, 40),
                Font = new Font(this.Font, FontStyle.Bold)    
            );

            lbAnoVeiculo = new BiblioLabel(
                Text = "Ano do Veiculo",
                Location = new Point(5, 70),
                Font = new Font(this.Font, FontStyle.Bold)    
            );

            lbPreco = new BiblioLabel(
                Text = "Preco",
                Location = new Point(5,  100),
                Font = new Font(this.Font, FontStyle.Bold)    
            );

            lbCor = new BiblioLabel(
                Text = "Cor",
                Location = new Point(5, 130),
                Font = new Font(this.Font, FontStyle.Bold)    
            );


            tbMarca = new BiblioTextBox(
                Location = new Point(105, 10),
                Size = new Size(100, 10)
            );
            tbModelo = new BiblioTextBox(
                Location = new Point(105, 40),
                Size = new Size(100, 10)
            );
            tbAnoVeiculo = new BiblioTextBox(
                Location = new Point(105, 70),
                Size = new Size(100, 10)
            );
            tbPreco = new BiblioTextBox(
                Location = new Point(105,  100),
                Size = new Size(100, 10)
            );
            tbCor = new BiblioTextBox(
                Location = new Point(105, 130),
                Size = new Size(100, 10)
            );


            this.Controls.Add(btnAtualiza);
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

            this.Text = "Atualização de Veículos Leves";
            this.Size = new Size(220, 220);
            Application.Run(this);
        }

        private void btnAtualizaClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Atualizar Veículo Leve?",
                "Atualização de Veículo Leve",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Atualização efetuada com Sucesso!");
            } else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Atualização Cancelada!");
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