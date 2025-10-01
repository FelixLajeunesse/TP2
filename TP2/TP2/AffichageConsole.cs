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

            for (int i = 0; i < parc.Attractions.Count; i++)
            {
                Console.WriteLine($"{parc.Attractions[i].Id}   {parc.Attractions[i].Type}   {parc.Attractions[i].Nom}     ?/{parc.Attractions[i].Capacite}");
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
