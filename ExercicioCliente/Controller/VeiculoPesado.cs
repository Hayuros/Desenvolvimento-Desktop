using System;
using System.Collections.Generic;

namespace Controller
{
    public class VeiculoPesado
    {
        public static Model.VeiculoPesado CriarVeiculoPesado(
            string Marca,
            string Modelo,
            string Ano,
            string Preco,
            string Restricoes
        )
        {
            int ConverteAno = Convert.ToInt32(Ano);
            double ConvertePreco = Convert.ToDouble(Preco);

            if (ConverteAno < 1990)
            {
                throw new Exception("Este carro é muito Antigo");
            }

            if (ConvertePreco < 0)
            {
                throw new Exception("O valor não pode ser Negativo");
            }

            return new Model.VeiculoPesado(
             Marca,
             Modelo,
             ConverteAno,
             ConvertePreco,
             Restricoes
            );
        }

        public static IEnumerable<Model.VeiculoPesado> ListaVeiculoPesado()
        {
            return Model.VeiculoPesado.GetVeiculoPesado();
        }

        public static Model.VeiculoPesado GetVeiculoPesado(int Id)
        {
            int TamanhoLista = Model.VeiculoPesado.GetCount();

            if (Id < 0 || TamanhoLista <= Id)
            {
                throw new Exception("O Id informado é Inválido");
            }

            return Model.VeiculoPesado.GetVeiculoPesado(Id);
        }

        public static Model.VeiculoPesado AtualizarVeiculoPesado(
            Model.VeiculoPesado veiculoPesado,
            string opcao,
            string valor
        ) {
            int campo = Convert.ToInt32(opcao);
            switch (campo)
            {
                case 1: {
                    return Model.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado, campo, valor);
                }
                case 2: {
                    return Model.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado, campo, valor);
                }
                case 3: {
                    return Model.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado, campo, valor);
                }
                case 4: {
                    return Model.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado, campo, valor);
                }
                case 5: {
                    return Model.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado, campo, valor);
                }
                default: {
                    throw new Exception("Operação Inválida");

                }
            }
        }

        public static void ExcluirVeiculoPesado(string StringId) {
            int Id = Convert.ToInt32(StringId);
            try
            {
                Model.VeiculoPesado.ExcluirVeiculoPesado(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Está exclusão não foi permitida/Id Inválido." +e.Message);
            }
        }
    }
}