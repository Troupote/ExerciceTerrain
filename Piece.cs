using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml1Terrain
{
    public class Piece
    {
        public int Superficie;
        public string Nom;

        public Piece(int superficie, string nom)
        {
            Superficie = superficie;
            Nom = nom;
        }

        public override string ToString()
        {
            string toString = String.Format("Nom = {0}\n", this.Nom);
            toString += String.Format("Superficie = {0}m²\n", this.Superficie);
            return toString;
        }
    }
}
