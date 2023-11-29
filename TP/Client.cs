using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    internal class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Ville { get; set; }
        public string CP { get; set; }
        public string Mail { get; set; }

        public Client(string nom, string prenom, string ville, string cp, string mail)
        {
            Nom = nom;
            Prenom = prenom;
            Ville = ville;
            CP = cp;
            Mail = mail;
        }

        public Client()
        {
        }

        public void AjouteClient()
        {

        }

        public void SupprimeClient()
        {

        }
    }
}
