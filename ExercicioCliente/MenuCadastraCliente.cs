using System;
using System.Windows.Forms;
using System.Drawing;

namespace TelaCLiente
{
    public class MenuCadastraCLiente : Form{
        public MenuCadastraCLiente() {
            //Criando os Botões
            Button Cadastra = new Button() {
                Text = "Cadastrar!",
                Location = new Point(15, 180),
                BackColor = System.Drawing.Color.Green
            };
            Button Cancela = new Button() {
                Text = "Cancelar!",
                Location = new Point(100, 180),
                BackColor = System.Drawing.Color.Red
            };

            //Criando as Labels
            Label textoInicial = new Label() {
                Text = "Cadastrando o Cliente",
                Location = new Point(80, 1),
                Size = new Size(155, 12)
                
            };
            Label nomeLabel = new Label() {
                Text = "Nome",
                Location = new Point(5, 35)
            };
            Label aniversarioLabel = new Label() {
                Text = "Aniversario",
                Location = new Point(5, 70)
            };
            Label identificacaoLabel = new Label() {
                Text = "Identificacao",
                Location = new Point(5, 105)
            };
            Label diasRetornoLabel = new Label() {
                Text = "DiasRetorno",
                Location = new Point(5, 140)
            };
            
            //Criando as Text Box's
            TextBox nomeTextBox = new TextBox() {
                Text = "Nome",
                Location = new Point(105, 35),
                Size = new Size(100, 10)
            };
            TextBox aniversarioTextBox = new TextBox() {
                Text = "Aniversario",
                Location = new Point(105, 70),
                Size = new Size(100, 10)
            };
            TextBox identificacaoTextBox = new TextBox() {
                Text = "Identificacao",
                Location = new Point(105, 105),
                Size = new Size(100, 10)
            };
            TextBox diasRetornoTextBox = new TextBox() {
                Text = "DiasRetorno",
                Location = new Point(105, 140),
                Size = new Size(100, 10)
            };


            //Adcionando os Objetos a tela
            this.Text = "Cadastro de Clientes";

            //Adicionando os Botões
            this.Controls.Add(Cadastra);
            this.Controls.Add(Cancela);

            //Adicionando as Labels
            this.Controls.Add(textoInicial);

            this.Controls.Add(nomeLabel);
            this.Controls.Add(aniversarioLabel);
            this.Controls.Add(identificacaoLabel);
            this.Controls.Add(diasRetornoLabel);

            // Adicionando as Text Box
            this.Controls.Add(nomeTextBox);
            this.Controls.Add(aniversarioTextBox);
            this.Controls.Add(identificacaoTextBox);
            this.Controls.Add(diasRetornoTextBox);
            
            
            //Setando o Tamanho
            this.Size = new Size(300, 250);
            Application.Run(this);
        }
    }
}