using System;
using System.Windows.Forms;
using System.Drawing;

namespace TelaCLiente
{
    public class MenuCadastraCLiente : Form{

        Button btnCadastra;
        Button btnCancela;

        Label lbTextoInicial;
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

        // MessageBox mbClienteCadastrado;

        public MenuCadastraCLiente() {
            //Criando os Botões
            btnCadastra = new Button() {
                Text = "Cadastrar!",
                Location = new Point(15, 275),
                BackColor = System.Drawing.Color.Green
            };
            btnCadastra.Click += new EventHandler(this.btnCadastraClick);
            
            btnCancela = new Button() {
                Text = "Cancelar!",
                Location = new Point(100, 275),
                BackColor = System.Drawing.Color.Red
            };
            btnCancela.Click += new EventHandler(this.btnCancelaClick);

            //Criando as Labels
            lbTextoInicial = new Label() {
                Text = "Cadastrando o Cliente",
                Location = new Point(40, 1),
                Size = new Size(155, 12)
                
            };
            lbNome = new Label() {
                Text = "Nome",
                Location = new Point(5, 35)
            };
            lbAniversario = new Label() {
                Text = "Aniversario",
                Location = new Point(5, 70)
            };
            lbIdentificacao = new Label() {
                Text = "Identificacao",
                Location = new Point(5, 105)
            };
            lbDiasRetorno = new Label() {
                Text = "DiasRetorno",
                Location = new Point(5, 140)
            };
            
            //Criando as Text Box
            tbNome = new TextBox() {
                Location = new Point(105, 35),
                Size = new Size(100, 10)
            };
            tbAniversario = new TextBox() {
                Location = new Point(105, 70),
                Size = new Size(100, 10)
            };
            tbIdentificacao = new TextBox() {
                Location = new Point(105, 105),
                Size = new Size(100, 10)
            };

            //Criando as Combo Box
            cbDiasRetorno = new ComboBox() {
                Location = new Point(105, 140),
                Size = new Size(100, 10)
            };      
            cbDiasRetorno.Items.AddRange(new string[] {"5", "10", "15", "20"});

            //Criando as Group Box
            gbSexo = new GroupBox() {
                Text = "Sexo",
                Location =  new Point(5, 175),
                Size = new Size(200, 80)
            };

            //Criando os Radio Button
            rbHomem = new RadioButton() {
                Text = "Homem",
                Location = new Point(8, 15)
            };
            rbMulher = new RadioButton() {
                Text = "Mulher",
                Location = new Point(8, 35)
            };
            rbNaoInformado = new RadioButton() {
                Text = "NaoInformado",
                Location = new Point(8, 55)
            };

            //Criando as Message Box
            // mbClienteCadastrado = new MessageBox();

            //Adcionando os Objetos a tela
            this.Text = "Cadastro de Clientes";

            //Adicionando os Botões
            this.Controls.Add(btnCadastra );
            this.Controls.Add(btnCancela);

            //Adicionando as Labels
            this.Controls.Add(lbTextoInicial);
            this.Controls.Add(lbNome);
            this.Controls.Add(lbAniversario);
            this.Controls.Add(lbIdentificacao);
            this.Controls.Add(lbDiasRetorno);

            // Adicionando as Text Box
            this.Controls.Add(tbNome);
            this.Controls.Add(tbAniversario);
            this.Controls.Add(tbIdentificacao);

            // Adicionando as Combo Box
            this.Controls.Add(cbDiasRetorno);
            
            //Adicionando as Group Box
            this.Controls.Add(gbSexo);
            
            //Adicionando os Radio Button
            gbSexo.Controls.Add(rbHomem);
            gbSexo.Controls.Add(rbMulher);
            gbSexo.Controls.Add(rbNaoInformado);
                        
            //Setando o Tamanho
            this.Size = new Size(220, 350);
            Application.Run(this);
        }
        private void btnCancelaClick(object sender, EventArgs e) {
            this.Close();
        }
        private void btnCadastraClick(object sender, EventArgs e) {
            this.Close();
        }
    }
}