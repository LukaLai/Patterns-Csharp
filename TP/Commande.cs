using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    internal class Commande
    {
        public string Nom { get; set; }
        public string Date { get; set; }
        public string Pays { get; set; }
        public string Client { get; set; }
        public string Livre { get; set; }

        public Commande (string nom, string date, string pays, string client,string livre)
        {
            Nom = nom;
            Date = date;
            Pays = pays;
            Client = client;
        }

        public Commande()
        {
        }

        public void AjouterCommande(string nom, string date, string pays, Client client, Livres livre)
        {
            Console.WriteLine($"Commande: {nom}, Date de la commande: {date}, Pays de la commande: {pays}, Client: {client.Nom} {client.Prenom}, Livre: {livre.Titre}");
        }
    }
}
