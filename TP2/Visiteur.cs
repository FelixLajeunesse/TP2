// <copyright file="Visiteur.cs" company="CSTJEAN">
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
    /// Cette classe permet de représenter un visiteur.
    /// </summary>
    public class Visiteur
    {
        /// <summary>
        /// Représente le nom d'un visiteur.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Représente une liste de string qui contient l'historique des actions du visiteur.
        /// </summary>
        public List<string> Historique { get; set; } = [];

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="nom">Nom du visiteur.</param>
        public Visiteur(string nom)
        {
            Nom = nom;
        }
    }
}
