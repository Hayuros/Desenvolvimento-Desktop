using System;

namespace View
{
    public static class Import
    {
        public static void DBImport()
        {
            Console.WriteLine("\n................................");
            Console.WriteLine("\nImportando Dados");
            Controller.Import.DBImport();
            Console.WriteLine("\nImportação Concluída");
            Console.WriteLine("\n................................");
        }
    }
}