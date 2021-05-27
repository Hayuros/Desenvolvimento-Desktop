using System;
using System.Windows.Forms;
using System.Drawing; 
using View.Biblio;

namespace TelaCliente
{
    public class MenuListaCliente : Form{

        BiblioButtonEdita btnEdita;
        BiblioButtonCancela btnCancela;

        BiblioLabel lbId;
        BiblioLabel lbNome;
        BiblioLabel lbAniversario;
        BiblioLabel lbIdentificacao;
        BiblioLabel lbDiasRetorno;

        BiblioTextBox tbNome;
        BiblioTextBox tbAniversario;

        BiblioMaskedTextBox mtbIdentificacao;

        BiblioNumericUpDown nupDiasRetorno;
        BiblioNumericUpDown nupId;

        public MenuListaCliente() {
            btnEdita = new BiblioButtonEdita(
                Text = this.Text,
                Location = new Point(20, 165),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnEdita.Click += new EventHandler(this.btnEditaClick);
            
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110, 165),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(this.btnCancelaClick);

            lbId = new BiblioLabel(
                Text = "Id Cliente",
                Location = new Point(5, 15),
                Font = new Font(this.Font, FontStyle.Bold)  
            );
            lbNome = new BiblioLabel(Text = "Nome",
                Location = new Point(5, 45),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbAniversario = new BiblioLabel(Text = "Aniversario",
                Location = new Point(5, 75),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbIdentificacao = new BiblioLabel(Text = "Identificação",
                Location = new Point(5, 105),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbDiasRetorno = new BiblioLabel(Text = "DiasRetorno",
                Location = new Point(5, 135),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            

            tbNome = new BiblioTextBox(
                Location = new Point(105, 45),
                Size = new Size(100, 10)
            );
            tbAniversario = new BiblioTextBox(
                Location = new Point(105, 75),
                Size = new Size(100, 10)
            );


            mtbIdentificacao = new BiblioMaskedTextBox(
                Location = new Point(105, 105),
                Size = new Size(100, 10)
            ) {
                Mask = "000.000.000-00"
            };


            nupDiasRetorno = new BiblioNumericUpDown(
                Location = new Point(105, 135),
                Size = new Size(100, 10)               
            ) {
                Value = 5,
                Maximum = 30,
                Minimum = 5,
                Increment = 5,
                ReadOnly = true
            };

            nupId = new BiblioNumericUpDown(
                Location = new Point(105, 15),
                Size = new Size(100, 10)               
            ) {
                Value = 5,
                Maximum = 30,
                Minimum = 5,
                Increment = 5,
                ReadOnly = true
            };
            

            this.Controls.Add(btnEdita );
            this.Controls.Add(btnCancela);
            this.Controls.Add(lbId);
            this.Controls.Add(lbNome);
            this.Controls.Add(lbAniversario);
            this.Controls.Add(lbIdentificacao);
            this.Controls.Add(lbDiasRetorno);
            this.Controls.Add(tbNome);
            this.Controls.Add(tbAniversario);
            this.Controls.Add(mtbIdentificacao);
            this.Controls.Add(nupDiasRetorno);
            this.Controls.Add(nupId);


            this.Text = "Edição de Clientes";
            this.Size = new Size(220, 225);
        }
        private void btnCancelaClick(object sender, EventArgs e) {
            this.Close();
        }
        private void btnEditaClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Editar Cliente?",
                "Edição do Cliente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                Controller.Cliente.ListaCliente();
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