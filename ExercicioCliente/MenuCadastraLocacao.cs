using System;
using System.Windows.Forms;
using System.Drawing; 

namespace TelaLocacao {
    public class MenuCadastraLocacao : Form {
        Button btnCadastra;
        Button btnCancela;

        Label lbIdCLiente;
        Label lbDataLocacao;
        Label lbIdVeiculoLeve;
        Label lbIdVeiculoPesado;

        TextBox tbDataLocacao;

        ComboBox cbIdCLiente;
        ComboBox cbIdVeiculoLeve;
        ComboBox cbIdVeiculoPesado;

        public MenuCadastraLocacao() {
            btnCadastra = new Button() {
                Text = "Cadastrar!",
                Location = new Point(25, 125),
                BackColor = System.Drawing.Color.Green
            };
            btnCadastra.Click += new EventHandler(btnCadastraClick);
            btnCancela = new Button() {
                Text = "Cancelar!",
                Location = new Point(110, 125),
                BackColor = System.Drawing.Color.Red
            };
            btnCancela.Click += new EventHandler(btnCancelaClick);

            
            lbIdCLiente = new Label() {
                Text = "Id Cliente", 
                Location = new Point(5, 25)
            };
            lbIdVeiculoLeve = new Label() {
                Text = "Id Veículo Leve",
                Location = new Point(5, 50)
            };
            lbIdVeiculoPesado = new Label() {
                Text = "Id Veículo Pesado",
                Location = new Point(5, 75)
            };
            lbDataLocacao = new Label() {
                Text = "Data de Locação",
                Location = new Point(5, 100)
            };

            tbDataLocacao = new TextBox() {
                Location = new Point(110, 100),
                Size = new Size(100, 15)
            };


            cbIdCLiente = new ComboBox() {
                Location = new Point(110, 25),
                Size = new Size(100, 10)
            };
            cbIdCLiente.Items.AddRange(new string[]{"1", "2", "3", "4"});

            cbIdVeiculoLeve = new ComboBox() {
                Location = new Point(110, 50),
                Size = new Size(100, 10)
            };
            cbIdVeiculoLeve.Items.AddRange(new string[]{"1", "2", "3", "4"});

            cbIdVeiculoPesado = new ComboBox() {
                Location = new Point(110, 75),
                Size = new Size(100, 10)
            };
            cbIdVeiculoPesado.Items.AddRange(new string[]{"1", "2", "3", "4"});


            this.Controls.Add(btnCadastra);  
            this.Controls.Add(btnCancela);   
            this.Controls.Add(lbIdCLiente);
            this.Controls.Add(lbIdVeiculoLeve);
            this.Controls.Add(lbIdVeiculoPesado);
            this.Controls.Add(cbIdCLiente);  
            this.Controls.Add(lbDataLocacao); 
            this.Controls.Add(cbIdVeiculoLeve);  
            this.Controls.Add(cbIdVeiculoPesado); 
            this.Controls.Add(tbDataLocacao);   

            this.Text = "Cadastro de Locações";
            this.Size = new Size(220, 200);
            Application.Run(this);
        }

        private void btnCancelaClick(object sender, EventArgs e) {
            // Application.Run(new Program());
            this.Close();
        }
        private void btnCadastraClick(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Cadastrar Locação?",
                "Cadastro de Locações",
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