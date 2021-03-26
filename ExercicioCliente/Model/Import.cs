using System;

namespace Model
{
    public static class Import
    {
        public static void DBImport()
        {
            //Importando Clientes
            new Cliente("José Carlos da Silva", Convert.ToDateTime(19 / 06 / 1968), "134.465.987-65", 15);

            new Cliente("Francisco dos Santos Cardoso", Convert.ToDateTime(13 / 02 / 1975), "985.164.654-97", 54);

            new Cliente("Antônio Carlos Silva", Convert.ToDateTime(09 / 06 / 1965), "649.460.492-49", 2);

            new Cliente("Ana Francisca", Convert.ToDateTime(05 / 09 / 1965), "164.497.982-20", 30);

            new Cliente("Vanessa Camila", Convert.ToDateTime(19 / 10 / 2000), "946.450.462-79", 9);

            new Cliente("Mariana do Carmo", Convert.ToDateTime(06 / 12 / 1998), "649.301.645-73", 90);

            //Importando Veículos Leves
            new VeiculoLeve("Fiat", "Toro Ranch", 2019, 1.250, "Vermelha");

            new VeiculoLeve("Fiat", "Argo", 2017, 950.00, "Branca");

            new VeiculoLeve("Fiat", "Cronos", 2015, 689.00, "Bordô");

            new VeiculoLeve("Renault", "Scenic", 2001, 350.00, "Verde");

            new VeiculoLeve("Renault", "Captur", 2018, 250.23, "Prata");

            new VeiculoLeve("Renault", "Logan", 2019, 584.65, "Grafite");

            new VeiculoLeve("Volkswagen", "Amarok", 2015, 900.00, "Preta");

            new VeiculoLeve("Volkswagen", "Gol", 2013, 165.63, "Vermelha");

            new VeiculoLeve("Volkswagen", "Saveiro", 2019, 264.65, "Azul");

            //Importando Veículos Pesados
            new VeiculoPesado("Volvo", "FH 540", 2019, 1.600, "Carteira D");

            new VeiculoPesado("Scania", "R 450", 2019, 548.00, "Carteira C");

            new VeiculoPesado("Mercedes Benz", "Actros 2651", 2019, 620.00, "Carteira D");

            new VeiculoPesado("Daf", "XF105 510", 2020, 540.60, "Carteira C");

            new VeiculoPesado("Volvo", "Fh 500", 2019, 1.450, "Carteira D");

            new VeiculoPesado("Mercedes Benz", "Axor 3344", 2019, 2.500, "Carteira C");
        }
    }
}