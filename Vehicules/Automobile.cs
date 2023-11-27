using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicules
{
    internal class Automobile
    {
        public string modele;
        public string couleur;

        public Automobile(string modele, string couleur) 
        {
            this.modele = modele;
            this.couleur = couleur;
        }
    }
}
