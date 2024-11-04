using System;

namespace Uml1Terrain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Piece Cuisine = new Piece(15, "Cuisine");
            Piece Salon = new Piece(20, "Salon");
            Piece Chambre1 = new Piece(10, "Chambre 1");
            Piece Chambre2 = new Piece(12, "Chambre 2");
            Piece SalleDeBain = new Piece(5, "Salle de bain");

            Maison UneMaison = new Maison("11 Rue des Chartreux, 69001 Lyon", 58f, 4, false,new List<Piece> {Cuisine,Salon});
            Maison UneAutreMaison = new Maison("4 place Saint Louis, 22100 Dinan", 86.5f, 5, true, new List<Piece> { Cuisine, Chambre1 });
            Maison UneDerniereMaison = new Maison("26 Boulevard Claude Lorrin, 40100 Dax", 25.2f, 2, false, new List<Piece> { Cuisine, Chambre2, Salon, SalleDeBain });

            Terrain UnTerrain = new Terrain("55 route cabossée, 29130 Locmaria-Plouzané", 5000f, 2, true);
            Terrain UnAutreTerrain = new Terrain("102 route des volcans, 63000 Clermont-Ferrand", 1500f, 4, false);

            List<Bien> CatalogueBiens = new List<Bien> { UneMaison, UneAutreMaison, UneDerniereMaison, UnTerrain, UnAutreTerrain };

            Proprietaire UnProprietaire = new Proprietaire("Dupont", "Jean", CatalogueBiens);

            foreach (Bien B in CatalogueBiens)
            {
                
                Console.WriteLine(B);
            }
        }
    }
}
