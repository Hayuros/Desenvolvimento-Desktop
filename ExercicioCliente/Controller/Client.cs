using System;
using System.Collections.Generic;

namespace Controller
{
    public static class Client
    {
        public static void CreateClient(
            int Id,
            string Name,
            string Birth,
            string Identification,
            int ReturnDays
        )
        {
            new Model.Client(int Id,
                string Name,
                string Birth,
                string Identification,
                int ReturnDays);
        }
    }
}
