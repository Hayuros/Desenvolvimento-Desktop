using System;
using System.Windows.Forms;
using System.Drawing; 
using View.Biblio;

namespace TelaCliente
{
    public class MenuAtualizaCliente : Form{

        BiblioButtonAtualiza btnAtualiza;
        BiblioButtonCancela btnCancela;

        BiblioLabel lbNome;
        BiblioLabel lbAniversario;
        BiblioLabel lbIdentificacao;
        BiblioLabel lbDiasRetorno;

        BiblioTextBox tbNome;
        BiblioTextBox tbAniversario;

        BiblioMaskedTextBox mtbIdentificacao;

        BiblioNumericUpDown nupDiasRetorno;

        BiblioGroupBox gbSexo;
        BiblioRadioButton rbHomem;
        BiblioRadioButton rbMulher;
        BiblioRadioButton rbNaoInformado;

        public MenuAtualizaCliente() {
            btnAtualiza = new BiblioButtonAtualiza(
                Text = this.Text,
                Location = new Point(20, 240),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnAtualiza.Click += new EventHandler(this.btnAtualizaClick);
            
            btnCancela = new BiblioButtonCancela(
                Text = this.Text,
                Location = new Point(110, 240),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCancela.Click += new EventHandler(this.btnCancelaClick);


            lbNome = new BiblioLabel(Text = "Nome",
                Location = new Point(5, 15),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbAniversario = new BiblioLabel(Text = "Aniversario",
                Location = new Point(5, 45),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbIdentificacao = new BiblioLabel(Text = "Identificação",
                Location = new Point(5, 75),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            lbDiasRetorno = new BiblioLabel(Text = "DiasRetorno",
                Location = new Point(5, 105),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            

            tbNome = new BiblioTextBox(
                Location = new Point(105, 15),
                Size = new Size(100, 10)
            );
            tbAniversario = new BiblioTextBox(
                Location = new Point(105, 45),
                Size = new Size(100, 10)
            );


            mtbIdentificacao = new BiblioMaskedTextBox(
                Location = new Point(105, 75),
                Size = new Size(100, 10)
            ) {
                Mask = "000.000.000-00"
            };


            nupDiasRetorno = new BiblioNumericUpDown(
                Location = new Point(105, 105),
                Size = new Size(100, 10)               
            ) {
                Value = 5,
                Maximum = 30,
                Minimum = 5,
                Increment = 5,
                ReadOnly = true
            };
            

            gbSexo = new BiblioGroupBox(
                Text = "Sexo",
                Location =  new Point(5, 135),
                Size = new Size(200, 90)
            );


            rbHomem = new BiblioRadioButton(
                Text = "Homem",
                Location = new Point(8, 15),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            rbMulher = new BiblioRadioButton(
                Text = "Mulher",
                Location = new Point(8, 35),
                Font = new Font(this.Font, FontStyle.Bold)
            );
            rbNaoInformado = new BiblioRadioButton(
                Text = "Nenhum",
                Location = new Point(8, 57),
                Font = new Font(this.Font, FontStyle.Bold)
            );


            this.Controls.Add(btnAtualiza );
            this.Controls.Add(btnCancela);
            this.Controls.Add(lbNome);
            this.Controls.Add(lbAniversario);
            this.Controls.Add(lbIdentificacao);
            this.Controls.Add(lbDiasRetorno);
            this.Controls.Add(tbNome);
            this.Controls.Add(tbAniversario);
            this.Controls.Add(mtbIdentificacao);
            this.Controls.Add(nupDiasRetorno);
            this.Controls.Add(gbSexo);
            gbSexo.Controls.Add(rbHomem);
            gbSexo.Controls.Add(rbMulher);
            gbSexo.Controls.Add(rbNaoInformado);

            this.Text = "Atualização de Clientes";
            this.Size = new Size(220, 305);
            Application.Run(this);
        }
        private void btnCancelaClick(object sender, EventArgs e) {
            this.Close();
        }
        private void btnAtualizaClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Atualizar Cliente?",
                "Atualização do Cliente",
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
    }
}