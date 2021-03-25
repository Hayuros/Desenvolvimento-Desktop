using System;

namespace View
{
    public static class Import
    {
        public static void DBImport() {
            Console.WriteLine("\n................................");
            Console.WriteLine("Importando Dados");
            Controller.Import.DBImport;
            Console.WriteLine("Importação Concluída");
            Console.WriteLine("\n................................");
        }
    }
}