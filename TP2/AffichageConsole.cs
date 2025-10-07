// <copyright file="AffichageConsole.cs" company="CSTJEAN">
// Félix Lajeunesse et Yoan Jalbert
// </copyright>
using System;
using System.Collections.Generic;
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
            for (int i = 0; i < map.Carte.GetLength(0); i++)
            {
                for (int j = 0; j < map.Carte.GetLength(1); j++)
                {
                    Console.Write(map.Carte[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine($"{gestionVisiteurs.VisiteursActuel.Count} visiteur(s) présent(s) dans le parc.\n");

            foreach (Attraction attraction in parc.Attractions.Values)
            {
                Console.WriteLine($"{attraction.Id}   {attraction.Type}   {attraction.Nom}     {gestionVisiteurs.AttractionsFileVisiteur[attraction.Id].Count}/{attraction.Capacite}");
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
    }
}
