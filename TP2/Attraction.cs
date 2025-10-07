// <copyright file="Attraction.cs" company="CSTJEAN">
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
    /// Représente les types d'attractions possibles.
    /// </summary>
    public enum Type
    {
        /// <summary>
        /// Représente une attraction de type sensation forte.
        /// </summary>
        S,

        /// <summary>
        /// Représente une attraction de type intermédiaire.
        /// </summary>
        I,

        /// <summary>
        /// Représente une attraction de type famille.
        /// </summary>
        F,

        /// <summary>
        /// Représente les toillettes.
        /// </summary>
        T,

        /// <summary>
        /// Représente un magasin.
        /// </summary>
        M,

        /// <summary>
        /// Représente un restaurant.
        /// </summary>
        R,
    }

    /// <summary>
    /// Cette classe permet de représenter une attraction dans le parc d'attractions.
    /// </summary>
    public class Attraction
    {
        /// <summary>
        /// Représente la gestion des visiteurs dans le parc.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Représente le nom de l'attraction.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Représente le type de l'attraction.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Représente la capacité maximale de l'attraction.
        /// </summary>
        public int Capacite { get; }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="id">Id de l'attraction.</param>
        /// <param name="nom">Nom de l'attraction.</param>
        /// <param name="type">Type d'attraction.</param>
        /// <param name="capacite">Capacité de l'attraction.</param>
        public Attraction(string id, string nom, Type type, int capacite)
        {
            Id = id;
            Nom = nom;
            Type = type;
            Capacite = capacite;
        }
    }
}
