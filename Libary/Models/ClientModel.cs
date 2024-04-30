using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    public class ClientModel
    {
        public int ID_Passageiro { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public List<BaggageModel> Baggages { get; set; } = new List<BaggageModel>();

        public string FullName
        {
            get
            {
                return $"{Nome} {Sobrenome}";
            }
        }


        public ClientModel() { }

        public ClientModel(string firstName, string lastName, string address, string email, string phone)
        {
            Nome = firstName;
            Sobrenome = lastName;
            Endereco = address;
            Email = email;
            Telefone = phone;
        }

        public ClientModel(int id, string address, string email, string phone)
        {
            ID_Passageiro = id;
            Endereco = address;
            Email = email;
            Telefone = phone;
        }


    }
}
