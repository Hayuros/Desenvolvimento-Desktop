using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace exercicios
{
    public class Pessoa
    {
        private string Nome;

        private double Peso;

        private double Altura;

        private string DataNascimento;

        public Pessoa(
            string Nome,
            double Peso,
            double Altura,
            string DataNascimento
        )
        {
            this.SetNome(Nome);
            this.SetPeso(Peso);
            this.SetAltura(Altura);
            this.SetDataNascimento(DataNascimento);
        }

        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }

        public void SetPeso(double Peso)
        {
            this.Peso = Peso;
        }

        public void SetAltura(double Altura)
        {
            this.Altura = Altura;
        }

        public void SetDataNascimento(string DataNascimento)
        {
            this.DataNascimento = DataNascimento;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public double GetPeso()
        {
            return this.Peso;
        }

        public double GetAltura()
        {
            return this.Altura;
        }

        public string GetDataNascimento()
        {
            return this.DataNascimento;
        }

        public override string ToString()
        {
            return $"Nome: {this.GetNome()}" + $" O IMC é: {this.GetIMC()}";
        }

        public double IMC()
        {
            return (Peso / (Altura * Altura));
        }

        public string GetIMC()
        {
            double imc = this.IMC();
            if (imc < 18.5)
            {
                return "Abaixo do Peso!";
            }
            else if (imc < 25.0)
            {
                return "Peso Ideal";
            }
            else if (imc < 30.0)
            {
                return "Levemente Abaixo do Peso";
            }
            else if (imc < 35.0)
            {
                return "Obesidade Grau 1";
            }
            else if (imc < 40.0)
            {
                return "Obesidade Grau 2";
            }
            else
            {
                return "Obesidade Mórbida";
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Pessoa pessoa = (Pessoa) obj;
            return this.Nome == pessoa.GetNome();
        }
    } // Termnina a classe pessoa.

    public class ContaCorrente
    {
        private double NumeroConta;

        private string Agencia;

        private double Saldo;

        private Titular Titular;

        private Gerente Gerente;

        //Criando o construtor da classe.
        public ContaCorrente(
            double NumeroConta,
            string Agencia,
            double Saldo,
            Titular Titular
        )
        {
            this.SetNumeroConta(NumeroConta);

            this.SetAgencia(Agencia);

            this.SetSaldo(Saldo);

            this.SetTitular(Titular);

            this.SetGerente(Gerente);
            this.SetSaldo(0);
        }

        //Set´s da classe
        public void SetNumeroConta(double NumeroConta)
        {
            this.NumeroConta = NumeroConta;
        }

        public void SetAgencia(string Agencia)
        {
            this.Agencia = Agencia;
        }

        public void SetSaldo(double Saldo)
        {
            this.Saldo = Saldo;
        }

        public void SetTitular(Titular Titular)
        {
            this.Titular = Titular;
        }

        public void SetGerente(Gerente Gerente)
        {
            this.Gerente = Gerente;
        }

        //Get´s da classe.
        public double GetNumeroConta()
        {
            return this.NumeroConta;
        }

        public string GetAgencia()
        {
            return this.Agencia;
        }

        public double GetSaldo()
        {
            return this.Saldo;
        }

        public string GetTitular()
        {
            return this.Titular;
        }

        public string GetGerente()
        {
            return this.Gerente;
        }

        public void Deposito(double valor)
        {
            this.SetSaldo(this.GetSaldo() + valor);
        }

        public void Saque(double valor)
        {
            this.SetSaldo(this.GetSaldo() - valor);
        }

        public override string ToString()
        {
            return $"Nome do Titular: {this.GetTitular()}" +
            $"\nNome do Gerente: {this.GetGerente()}" +
            $"\nAgência: {this.GetAgencia()}" +
            $"\nNúmero Conta: {this.GetNumeroConta()}" +
            $"\nSaldo: {this.GetSaldo()}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            ContaCorrente contacorrente = (ContaCorrente) obj;
            return this.GetNumeroConta() == contaCorrente.GetNumeroConta() &&
            this.GetAgencia() == contaCorrente.GetAgencia();
        }
    } // Termina a classe conta corrente.

    public class Titular : Pessoa
    {
        private string Cpf;

        public Titular(
            string Nome,
            double Peso,
            double Altura,
            string DataNascimento,
            string Cpf
        ) :
            base(Nome, Peso, Altura, DataNascimento)
        {
            this.SetCpf(Cpf);
        }

        public void SetCpf(string Cpf)
        {
            this.Cpf = Cpf;
        }

        public string GetCpf()
        {
            return this.Cpf;
        }
    } // Termino da classe titular.

    public class Gerente : Pessoa
    {
        private string Matricula;

        public Gerente(
            string Nome,
            double Peso,
            double Altura,
            string DataNascimento,
            string Matricula
        ) :
            base(Nome, Peso, Altura, DataNascimento)
        {
            this.SetMatricula(Matricula);
        }

        public void SetMatricula(string Matricula)
        {
            this.Matricula = Matricula;
        }

        public string GetMatricula()
        {
            return this.Matricula;
        }

        public override string ToString()
        {
            return $"Nome: {this.GetNome()}\n" +
            $"Matrícula: {this.GetMatricula()}";
        }
    } //Termino da classe gerente.

    public class Program
    {
        public static void Main(string[] args)
        {
            int menu = 0;
            do
            {
                Console.WriteLine("Digite a opçaõ desejada:");
                Console.WriteLine("[0] - Sair.");
                Console.WriteLine("[1] - Verificação de Par ou Ímpar.");
                Console.WriteLine("[2] - Verificaçao de Números Primos.");
                Console.WriteLine("[3] - Verificaçao de Números Fatoriais.");
                Console.WriteLine("[4] - Array com valores.");
                Console.WriteLine("[5] - Média da temperatura anual.");
                Console.WriteLine("[6] - Fila de banco.");
                Console.WriteLine("[7] - Cadastrar Pessoa.");
                Console.WriteLine("[8] - Conta Corrente.");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        {
                            Console.WriteLine("Agradecemos a Preferência");
                            break;
                        }
                    case 1:
                        {
                            Par();
                            break;
                        }
                    case 2:
                        {
                            Primo();
                            break;
                        }
                    case 3:
                        {
                            Fatorial();
                            break;
                        }
                    case 4:
                        {
                            ArrayValores();
                            break;
                        }
                    case 5:
                        {
                            MediaTempAno();
                            break;
                        }
                    case 6:
                        {
                            FilaBanco();
                            break;
                        }
                    case 7:
                        {
                            CadastrarPessoa();
                            break;
                        }
                    case 8:
                        {
                            ContaCorrente();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção não disponível");
                            break;
                        }
                }
            }
            while (menu != 0);
        } // Termino da classe main.

        public static void Par()
        {
            Console.WriteLine("Digite o Valor:");
            int valor = Convert.ToInt32(Console.ReadLine());

            if ((valor % 2) == 0)
            {
                Console.WriteLine($"O númnero {valor} é Par");
            }
            else
            {
                Console.WriteLine($"O número {valor} é Ímpar");
            }
        } //Termino do programa par.

        public static void Primo()
        {
            Console.WriteLine("Digite o Valor:");
            int valor = Convert.ToInt32(Console.ReadLine());
            bool primo = true;

            for (int contador = valor; contador > 1; contador--)
            {
                if ((valor % contador) == 0)
                {
                    primo = false;
                    break;
                }
            }
            if (primo)
            {
                Console.WriteLine($"O número {valor} é Primo");
            }
            else
            {
                Console.WriteLine($"O número {valor} Não é Primo");
            }
        } //Termino do programa primo.

        public static void Fatorial()
        {
            Console.WriteLine("Digite o Valor:");
            int valor = Convert.ToInt32(Console.ReadLine());
            int contador = valor;
            int resultado = 1;

            do
            {
                resultado += contador;
                contador--;
            }
            while (contador > 0);
            Console.WriteLine($"O fatorial de {valor} é: {resultado}");
        } //Termino do programa fatorial.

        public static void ArrayValores()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + " valor:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j < array.Length; j++)
            {
                Console
                    .WriteLine((array[j] % 2 == 0)
                        ? "Valor na posição" + j + "é par"
                        : "Valor na posição" + j + "é ímpar");
            }
        } //termino do programa de vetores de array.

        public static void MediaTempAno()
        {
            int[] temp = new int[12];
            int media = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                Console
                    .WriteLine("Digite a temperatura do " + (i + 1) + " mês:");
                temp[i] = Convert.ToInt32(Console.ReadLine());
                media += temp[i];
            }
            Console.WriteLine($"A temperatura média anual é: {(media / 12)}");
        } //Termino do programa da média de temperaturas.

        public static void FilaBanco()
        {
            int senha = 1;
            Queue<int> fila = new Queue<int>();
            int opcao = 0;

            do
            {
                Console.WriteLine("[1] - Retirar Senha.");
                Console.WriteLine("[2] - Chamar Senha.");
                Console
                    .WriteLine("[3] - Quantidade de pessoas a serem chamadas.");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            fila.Enqueue (senha);
                            senha++;
                            Console.WriteLine($"A senha retirada é: {senha}");
                            break;
                        }
                    case 2:
                        {
                            int chamar = fila.Dequeue();
                            Console
                                .WriteLine($"A senha a ser chamada é: {senha}");
                            break;
                        }
                    case 3:
                        {
                            foreach (int valor in fila)
                            {
                                Console.WriteLine (valor);
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção Inválida");
                            break;
                        }
                }
            }
            while (opcao != 0);
        } //Termino do programa da fila do banco.

        public static void CadastrarPessoa()
        {
            Console.WriteLine("Digite o Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a Altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Data de Nascimento: ");
            string dataNascimento = Console.ReadLine();

            Console.WriteLine(new Pessoa(nome, altura, peso, dataNascimento));
        } //Termino do programa de cadastro de pessoas e calculo de imc.

        public static void ContaCorrente()
        {
            Console.WriteLine("Digite o Nome do Titular: ");
            string nomeTitular = Console.ReadLine();
            Titular titular = new Titular(nomeTitular, 0, 0, "", "");

            Console.WriteLine("Digite o Nome do Gerente: ");
            string nomeGerente = Console.ReadLine();
            Gerente gerente = new Gerente(nomeGerente, 0, 0, "", "");

            Console.WriteLine("Digite o Número da Conta: ");
            string numeroConta = Console.ReadLine();

            Console.WriteLine("Digite a Agência: ");
            string agencia = Console.ReadLine();

            ContaCorrente conta =
                new ContaCorrente(numeroConta, agencia, titular, gerente);
            int repeticao = 0;
            do
            {
                Console.WriteLine("Digite a operação:");
                Console.WriteLine("[1] - Depósito");
                Console.WriteLine("[2] - Saque");
                Console.WriteLine("[3] - Saldo");
                int operacao = Convert.ToInt32(Console.ReadLine());
                switch (operacao)
                {
                    case 0:
                        {
                            Console
                                .WriteLine("Obrigado por utilizar o Programa!");
                        }
                        break;
                    case 1:
                        {
                            Console.WriteLine("Digite o valor para Depósito: ");
                            conta
                                .Deposito(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Digite o valor para Sacar: ");
                            conta.Saque(Convert.ToDouble(Console.ReadLine()));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine (conta);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção Inválida");
                            break;
                        }
                }
                Console.WriteLine("Deseja realizar outra operação?");
                Console.WriteLine("[1] - Sim");
                repeticao = Convert.ToInt32(Console.ReadLine());
            }
            while (repeticao == 1);
        } //Termino do programa da conta corrente.
    }
} // Termino do programa.