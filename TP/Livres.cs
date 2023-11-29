using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    internal class Livres
    {
        public string Titre { get; set; }
        public string Categorie { get; set; }
        public string Auteur { get; set; }
        public string Langue { get; set; }
        public string Date { get; set; }

        public Livres(string titre,string auteur, string categorie, string langue, string date)
        {
            Titre = titre;
            Auteur = auteur;
            Categorie = categorie;
            Langue = langue;
            Date = date;
        }

        public Livres()
        {
        }


    }

}
