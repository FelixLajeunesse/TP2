using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class AffichageConsole
    {

        public static void Afficher(Parc parc, Map map, GestionVisiteurs gestionVisiteurs)
        {
            for (int i = 0; i < map.Carte.GetLength(0); i++)
            {
                for(int j = 0; j < map.Carte.GetLength(1); j++)
                {
                    Console.Write(map.Carte[i, j]);                   
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{gestionVisiteurs.VisiteursActuel.Count} visiteur(s) présent(s) dans le parc.\n");

            int compteur = 0;
            foreach (Attraction attraction in parc.Attractions.Values)
            {
                compteur++;
                Console.WriteLine($"{attraction.Id}   {attraction.Type}   {attraction.Nom}     {gestionVisiteurs.attractionsFileVisiteur[attraction.Id].Count}/{attraction.Capacite}");
            }
            
        }

        public static void AfficherHistoriqueVisiteur(Visiteur visiteur)
        {
            Console.WriteLine($" ### {visiteur.Nom} ###");

            for (int i = 0; i < visiteur.Historique.Count; i++)
            {
                Console.WriteLine($"{visiteur.Historique[i]}.");
            }
        }
    }
}
