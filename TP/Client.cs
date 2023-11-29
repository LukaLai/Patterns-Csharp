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

        public static void ListerClients(List<Client> clients)
        {
            Console.WriteLine("Liste des clients :");

            foreach (var client in clients)
            {
                Console.WriteLine($"Nom: {client.Nom}, Prénom: {client.Prenom}, Adresse: {client.Ville}, Code postal: {client.CP}, Email: {client.Mail}");
            }
        }

        public void SupprimeClient()
        {

        }
    }
}
