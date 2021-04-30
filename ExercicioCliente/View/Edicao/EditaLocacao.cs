using System;
using System.Windows.Forms;
using System.Drawing; 
using View.Biblio;

namespace TelaLocacao {
    public class MenuEditaLocacao : Form {
        BiblioButtonEdita btnEdita;
        BiblioButtonCancela btnCancela;

        BiblioLabel lbIdCLiente;
        BiblioLabel lbDataLocacao;
        BiblioLabel lbIdVeiculoLeve;
        BiblioLabel lbIdVeiculoPesado;

        BiblioTextBox tbDataLocacao;

        BiblioComboBox cbIdCLiente;
        BiblioComboBox cbIdVeiculoLeve;
        BiblioComboBox cbIdVeiculoPesado;

        public MenuEditaLocacao() {
            btnEdita = new BiblioButtonEdita(
                Text = this.Text,
                Location = new Point(25, 125),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnEdita.Click += new EventHandler(btnEditaClick);
            
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110, 125),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(btnCancelaClick);

            
            lbIdCLiente = new BiblioLabel(
                Text = "Id Cliente", 
                Location = new Point(5, 25),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbIdVeiculoLeve = new BiblioLabel(
                Text = "Id Veículo Leve",
                Location = new Point(5, 50),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbIdVeiculoPesado = new BiblioLabel(
                Text = "Id Veículo Pesado",
                Location = new Point(5, 75),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbDataLocacao = new BiblioLabel(
                Text = "Data de Locação",
                Location = new Point(5, 100),
                Font = new Font(this.Font, FontStyle.Bold)
            );

            tbDataLocacao = new BiblioTextBox(
                Location = new Point(110, 100),
                Size = new Size(100, 15)
            );


            cbIdCLiente = new BiblioComboBox(
                Location = new Point(110, 25),
                Size = new Size(100, 10)
            );
            cbIdCLiente.Items.AddRange(new string[]{"1", "2", "3", "4"});

            cbIdVeiculoLeve = new BiblioComboBox(
                Location = new Point(110, 50),
                Size = new Size(100, 10)
            );
            cbIdVeiculoLeve.Items.AddRange(new string[]{"1", "2", "3", "4"});

            cbIdVeiculoPesado = new BiblioComboBox(
                Location = new Point(110, 75),
                Size = new Size(100, 10)
            );
            cbIdVeiculoPesado.Items.AddRange(new string[]{"1", "2", "3", "4"});


            this.Controls.Add(btnEdita);  
            this.Controls.Add(btnCancela);   
            this.Controls.Add(lbIdCLiente);
            this.Controls.Add(lbIdVeiculoLeve);
            this.Controls.Add(lbIdVeiculoPesado);
            this.Controls.Add(cbIdCLiente);  
            this.Controls.Add(lbDataLocacao); 
            this.Controls.Add(cbIdVeiculoLeve);  
            this.Controls.Add(cbIdVeiculoPesado); 
            this.Controls.Add(tbDataLocacao);   

            this.Text = "Edição de Locações";
            this.Size = new Size(220, 200);
            Application.Run(this);
        }

        private void btnCancelaClick(object sender, EventArgs e) {
            // Application.Run(new Program());
            this.Close();
        }
        private void btnEditaClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Editar Locação?",
                "Edição de Locações",
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
    }
}