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
        /// Constructeur.
        /// </summary>
        /// <param name="nom">Nom du visiteur.</param>
        public Visiteur(string nom)
        {
            Nom = nom;
        }

        /// <summary>
        /// Représente le nom d'un visiteur.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Représente une liste de string qui contient l'historique des actions du visiteur.
        /// Ont a choisient la list, car elle a un accès plus rapide que la linkedList et un ajout assez rapide par rapport au array
        /// mais moins rapide que la linkedList, mais puisuqu'a chaque fois que la list est pleine, celle-ci double
        /// sa grandeur, ce qui la rend assez rapide pour ce contexte.
        /// </summary>
        public List<string> Historique { get; set; } = [];
    }
}
