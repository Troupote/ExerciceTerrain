using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml1Terrain
{
    public class Proprietaire
    {
        public string Nom;
        public string Prenom;
        public List<Bien> Biens;

        public Proprietaire(string nom, string prenom, List<Bien> ListBiens)
        {
            Nom = nom;
            Prenom = prenom;
            Biens = ListBiens;
        }

        public override string ToString()
        {
            string toString = String.Format("Nom = {0}\n", this.Nom);
            toString += String.Format("Prénom = {0}\n", this.Prenom);
            toString += "Biens :\n";
            foreach (Bien bien in this.Biens)
            {
                toString += bien.ToString();
            }
            return toString;
        }

        }
}
