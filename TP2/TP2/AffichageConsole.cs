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

        }

        public static void AfficherHistoriqueVisiteur(Visiteur visiteur)
        {
            Console.WriteLine($" ### {visiteur.Nom} ###");

            for (int i = 0; i < visiteur.historique.Count; i++)
            {
                Console.WriteLine($"{visiteur.historique[i]}.");
            }
        }
    }
}
