using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exEcomendasTutorial5.entidies
{
    internal class Client
    {
        public string name { get; private set; }
        private string email;
        private DateTime birthdate;

        public Client(string name, string email, DateTime birthdate)
        {
            this.name = name;
            this.email = email;
            this.birthdate = birthdate;
        }

        public override string ToString()
        {
            return $"\n\nDados do cliente: {name},\n\tEmail: {email},\n\tData de nascimento {birthdate.ToLongDateString()}";
        }
    }
}
