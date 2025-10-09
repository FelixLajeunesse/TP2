// <copyright file="AffichageConsole.cs" company="CSTJEAN">
// Félix Lajeunesse et Yoan Jalbert
// </copyright>
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    /// <summary>
    /// Cette classe permet d'afficher des informations dans la console.
    /// </summary>
    public class AffichageConsole
    {
        /// <summary>
        /// Méthode qui permet d'afficher la carte du parc dans la console.
        /// </summary>
        /// <param name="parc">Parc d'attraction.</param>
        /// <param name="map">La carte du parc d'attraction.</param>
        /// <param name="gestionVisiteurs">Permet de faire la gestion des visiteurs.</param>
        public static void Afficher(Parc parc, Map map, GestionVisiteurs gestionVisiteurs)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int i = 0; i < map.Carte.GetLength(0); i++)
            {
                for (int j = 0; j < map.Carte.GetLength(1); j++)
                {
                    if (map.Carte[i, j].Trim() != "-----")
                    {
                        Console.ForegroundColor = DeterminerCouleurAttraction(map.Carte[i, j].Trim(), gestionVisiteurs);
                    }

                    Console.Write(map.Carte[i, j]);
                    Console.ResetColor();
                }

                Console.WriteLine();
            }

            Console.WriteLine($"{gestionVisiteurs.VisiteursActuel.Count} visiteur(s) présent(s) dans le parc.\n");

            foreach (Attraction attraction in parc.Attractions.Values)
            {
                Console.ForegroundColor = DeterminerCouleurAttraction(attraction.Id, gestionVisiteurs);
                Console.Write("{0,2}", "\u2B24");
                Console.ResetColor();

                Console.WriteLine($"{attraction.Id,7} {attraction.Nom,17} ({attraction.Type})  {gestionVisiteurs.AttractionsFileVisiteur[attraction.Id].Count,8} / {attraction.Capacite}");
            }
        }

        /// <summary>
        /// Permet d'afficher l'historique d'un visiteur dans la console.
        /// </summary>
        /// <param name="visiteur">Parc d'attraction.</param>
        public static void AfficherHistoriqueVisiteur(Visiteur visiteur)
        {
            Console.WriteLine($" ### {visiteur.Nom} ###");

            for (int i = 0; i < visiteur.Historique.Count; i++)
            {
                Console.WriteLine($"{visiteur.Historique[i]}.");
            }
        }

        /// <summary>
        /// Détermine la couleur d'affichage d'une attraction en fonction de son état.
        /// </summary>
        /// <param name="id">L'identifiant de l'attraction.</param>
        /// <param name="gestionVisiteurs">La gestion des visiteurs.</param>
        /// <returns>La couleur d'affichage de l'attraction.</returns>
        public static ConsoleColor DeterminerCouleurAttraction(string id, GestionVisiteurs gestionVisiteurs)
        {
            if (gestionVisiteurs.AttractionsFileVisiteur[id].Count == 3)
            {
                return ConsoleColor.Yellow;
            }
            else if (gestionVisiteurs.AttractionsFileVisiteur[id].Count == 4)
            {
                return ConsoleColor.Red;
            }
            else
            {
                return ConsoleColor.Green;
            }
        }
    }
}
