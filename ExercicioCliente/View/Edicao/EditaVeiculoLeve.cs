using System;
using System.Windows.Forms;
using System.Drawing;
using View.Biblio;

namespace TelaVeiculoLeve
{
    public class MenuEditaVeiculoLeve : Form{
        BiblioButtonEdita btnEdita;
        BiblioButtonCancela btnCancela;
        
        BiblioLabel lbMarca;
        BiblioLabel lbModelo;
        BiblioLabel lbAnoVeiculo;
        BiblioLabel lbPreco;
        BiblioLabel lbCor;

        BiblioTextBox tbMarca;
        BiblioTextBox tbModelo;
        BiblioTextBox tbPreco;
        BiblioTextBox tbCor;

        BiblioDateTimePicker dtpAnoVeiculo;
        
        
        public MenuEditaVeiculoLeve() {           

            btnEdita = new BiblioButtonEdita(
                Text = this.Text,
                Location = new Point(30, 160),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnEdita.Click += new EventHandler(this.btnEditaClick);
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
            tbPreco = new BiblioTextBox(
                Location = new Point(105,  100),
                Size = new Size(100, 10)
            );
            tbCor = new BiblioTextBox(
                Location = new Point(105, 130),
                Size = new Size(100, 10)
            );

            dtpAnoVeiculo = new BiblioDateTimePicker(
                Location = new Point(105, 70),
                Size = new Size(100, 10)                
            ) {
                MaxDate = DateTime.Today,
                MinDate = new DateTime(2005, 12, 31),
                CustomFormat = "yyyy",
                Format = DateTimePickerFormat.Custom
            };


            this.Controls.Add(btnEdita);
            this.Controls.Add(btnCancela);
            this.Controls.Add(lbMarca);
            this.Controls.Add(lbModelo);
            this.Controls.Add(lbAnoVeiculo);
            this.Controls.Add(lbPreco);
            this.Controls.Add(lbCor);
            this.Controls.Add(tbMarca);
            this.Controls.Add(tbModelo);
            this.Controls.Add(tbPreco);
            this.Controls.Add(tbCor);
            this.Controls.Add(dtpAnoVeiculo);


            this.Text = "Edição de Veículos Leves";
            this.Size = new Size(220, 220);
            Application.Run(this);
        }

        private void btnEditaClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Editar Veículo Leve?",
                "Edição de Veículo Leve",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Edição efetuada com Sucesso!");
            } else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Edição Cancelada!");
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