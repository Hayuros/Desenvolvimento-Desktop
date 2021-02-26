using System;
using System.Collections.Generic;

namespace Model
{
    public class Client
    {
        private int Id; // Identificador Único (ID)

        private string Name; // Nome

        private string Birth; // Data de Nascimento

        private string Identification; // C.P.F.

        private int ReturnDays; // Dias para Devolução

        public Client(
            int Id,
            string Name,
            string Birth,
            string Identification,
            int ReturnDays
        )
        {
            this.Id = Id;
            this.Name = Name;
            this.Birth = Birth;
            this.Identification = Identification;
            this.ReturnDays = ReturnDays;
        }

        public void SetId(int Id)
        {
            this.Id = Id;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public void SetBirth(string Birth)
        {
            this.Birth = Birth;
        }

        public void SetIdentification(string Identification)
        {
            this.Identification = Identification;
        }

        public void SetReturnDays(int ReturnDays)
        {
            this.ReturnDays = ReturnDays;
        }

        public int GetId()
        {
            return this.Id;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetBirth()
        {
            return this.Birth;
        }

        public string GetIdentification()
        {
            return this.Identification;
        }

        public int GetReturnDays()
        {
            return this.ReturnDays;
        }

        public override string ToString()
        {
            return $"Id: {this.GetId()}" +
            $"Nome: {this.GetName()}" +
            $"CPF: {this.GetIdentification()}" +
            $"Dias de retorno: {this.GetReturnDays()}";
        }
    }
}
