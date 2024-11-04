using System;

namespace ExemplePOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Terrain UneTerrain = new Terrain("11 Rue des Chartreux, 69001 Lyon", 58f, 4, false);
            Terrain UneAutreTerrain = new Terrain("4 place Saint Louis, 22100 Dinan", 86.5f, 5, true);
            Terrain UneDerniereTerrain = new Terrain("26 Boulevard Claude Lorrin, 40100 Dax", 25.2f, 4, false);

            Terrain[] CatalogueTerrains = new Terrain[] { UneTerrain, UneAutreTerrain, UneDerniereTerrain };

            foreach (Terrain T in CatalogueTerrains)
            {
                Console.WriteLine(T);
                Console.WriteLine();
            }
        }
    }
}

