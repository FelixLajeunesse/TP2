// <copyright file="Map.cs" company="CSTJEAN">
// Félix Lajeunesse et Yoan Jalbert
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    /// <summary>
    /// Cette classe qui permet de représenter la map du parc.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Représente la carte du parc.
        /// </summary>
        public string[,] Carte = ChargerMap();

        /// <summary>
        /// Permet de charger la map du parc à partir d'un fichier texte.
        /// </summary>
        /// <returns> Retourne un tableau 2D représentant la carte du parc.</returns>
        public static string[,] ChargerMap()
        {
            string path = "map.txt";

            string[] text = File.ReadAllLines(path);

            string[] grandeurTableau = text[0].Split(';');

            string[,] carte = new string[Convert.ToInt32(grandeurTableau[0]), Convert.ToInt32(grandeurTableau[1])];

            for (int i = 0; i < carte.GetLength(0); i++)
            {
                string[] ligne = text[i + 1].Split("  ");
                for (int j = 0; j < carte.GetLength(1); j++)
                {
                    carte[i, j] = ligne[j];
                }
            }

            return carte;
        }
    }
}
