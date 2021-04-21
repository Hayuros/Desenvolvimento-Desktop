using System;
using System.Windows.Forms;
using System.Drawing; 
using View.Biblio;

namespace TelaCLiente
{
    public class MenuCadastraCLiente : Form{

        BiblioButtonCadastra btnCadastra;
        BiblioButtonCancela btnCancela;

        BiblioLabel lbNome;
        BiblioLabel lbAniversario;
        BiblioLabel lbIdentificacao;
        BiblioLabel lbDiasRetorno;

        BiblioTextBox tbNome;
        BiblioTextBox tbAniversario;
        BiblioTextBox tbIdentificacao;

        BiblioComboBox cbDiasRetorno;

        BiblioGroupBox gbSexo;

        BiblioRadioButton rbHomem;
        BiblioRadioButton rbMulher;
        BiblioRadioButton rbNaoInformado;

        public MenuCadastraCLiente() {
            btnCadastra = new BiblioButtonCadastra(
                Text = this.Text,
                Location = new Point(20, 240),
                BackColor = this.BackColor,
                Font = new Font(this.Font, FontStyle.Bold)
            );
            btnCadastra.Click += new EventHandler(this.btnCadastraClick);
            
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
            tbIdentificacao = new BiblioTextBox(
                Location = new Point(105, 75),
                Size = new Size(100, 10)
            );


            cbDiasRetorno = new BiblioComboBox(
                Location = new Point(105, 105),
                Size = new Size(100, 10)
            );
            cbDiasRetorno.Items.AddRange(new string[] {"5", "10", "15", "20"});


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


            this.Controls.Add(btnCadastra );
            this.Controls.Add(btnCancela);
            this.Controls.Add(lbNome);
            this.Controls.Add(lbAniversario);
            this.Controls.Add(lbIdentificacao);
            this.Controls.Add(lbDiasRetorno);
            this.Controls.Add(tbNome);
            this.Controls.Add(tbAniversario);
            this.Controls.Add(tbIdentificacao);
            this.Controls.Add(cbDiasRetorno);
            this.Controls.Add(gbSexo);
            gbSexo.Controls.Add(rbHomem);
            gbSexo.Controls.Add(rbMulher);
            gbSexo.Controls.Add(rbNaoInformado);

            this.Text = "Cadastro de Clientes";
            this.Size = new Size(220, 305);
            Application.Run(this);
        }
        private void btnCancelaClick(object sender, EventArgs e) {
            // Application.Run(new Program());
            this.Close();
        }
        private void btnCadastraClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Cadastrar Cliente?",
                "Cadastro do Cliente",
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
    }
}