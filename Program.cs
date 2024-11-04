﻿using System;
using System.Text.RegularExpressions;

namespace ExemplePOO
{
    public class Terrain
    {
        public string Adresse;
        public float Superficie;
        public int NbCoteCloture;
        public bool Rivière;

        public Terrain(string adresse, float superficie, int nbCoteCloture, bool rivière)
        {
            Adresse = adresse;
            Superficie = superficie;
            NbCoteCloture = nbCoteCloture;
            Rivière = rivière;
        }

        public override string ToString()
        {
            string toString = String.Format("Adresse = {0}\n", this.Adresse);
            toString += String.Format("Superficie = {0}m²\n", this.Superficie);
            toString += String.Format("Nombre de coté de cloture = {0}\n", this.NbCoteCloture);
            toString += String.Format("Présence d'un Rivière = {0}\n", this.Rivière ? "Oui" : "Non");
            toString += String.Format("> VALEUR = {0}$", this.EvaluationValeur());
            return toString;
        }

        public float EvaluationValeur()
        {
            int facteur = 3000;

            if (this.Rivière) { facteur += 500; }
            if (this.NbCoteCloture > 3) { facteur += 200; }

            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.Adresse, @"\bLyon\b")) { facteur += 2000; }

            return this.Superficie * facteur;
        }
    }
}

