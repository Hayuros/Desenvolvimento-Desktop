using System;
using System.Windows.Forms;
using System.Drawing; 

namespace TelaCLiente
{
    public class MenuCadastraCLiente : Form{

        Button btnCadastra;
        Button btnCancela;

        Label lbNome;
        Label lbAniversario;
        Label lbIdentificacao;
        Label lbDiasRetorno;

        TextBox tbNome;
        TextBox tbAniversario;
        TextBox tbIdentificacao;

        ComboBox cbDiasRetorno;

        GroupBox gbSexo;

        RadioButton rbHomem;
        RadioButton rbMulher;
        RadioButton rbNaoInformado;

        public MenuCadastraCLiente() {
            btnCadastra = new Button() {
                Text = "Cadastrar!",
                Location = new Point(20, 240),
                BackColor = System.Drawing.Color.Green
            };
            btnCadastra.Click += new EventHandler(this.btnCadastraClick);
            
            btnCancela = new Button() {
                Text = "Cancelar!",
                Location = new Point(110, 240),
                BackColor = System.Drawing.Color.Red
            };
            btnCancela.Click += new EventHandler(this.btnCancelaClick);


            lbNome = new Label() {
                Text = "Nome",
                Location = new Point(5, 15)
            };
            lbAniversario = new Label() {
                Text = "Aniversario",
                Location = new Point(5, 45)
            };
            lbIdentificacao = new Label() {
                Text = "Identificação",
                Location = new Point(5, 75)
            };
            lbDiasRetorno = new Label() {
                Text = "DiasRetorno",
                Location = new Point(5, 105)
            };
            

            tbNome = new TextBox() {
                Location = new Point(105, 15),
                Size = new Size(100, 10)
            };
            tbAniversario = new TextBox() {
                Location = new Point(105, 45),
                Size = new Size(100, 10)
            };
            tbIdentificacao = new TextBox() {
                Location = new Point(105, 75),
                Size = new Size(100, 10)
            };


            cbDiasRetorno = new ComboBox() {
                Location = new Point(105, 105),
                Size = new Size(100, 10)
            };      
            cbDiasRetorno.Items.AddRange(new string[] {"5", "10", "15", "20"});


            gbSexo = new GroupBox() {
                Text = "Sexo",
                Location =  new Point(5, 135),
                Size = new Size(200, 90)
            };


            rbHomem = new RadioButton() {
                Text = "Homem",
                Location = new Point(8, 15)
            };
            rbMulher = new RadioButton() {
                Text = "Mulher",
                Location = new Point(8, 35)
            };
            rbNaoInformado = new RadioButton() {
                Text = "Nao Informado",
                Location = new Point(8, 57)
            };


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