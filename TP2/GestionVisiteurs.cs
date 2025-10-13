// <copyright file="GestionVisiteurs.cs" company="CSTJEAN">
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
    /// Cette classe permet de faire la gestion des visiteurs dans le parc.
    /// </summary>
    public class GestionVisiteurs
    {
        private Parc _parc;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="parc">Le parc où ce trouve les attractions.</param>
        public GestionVisiteurs(Parc parc)
        {
            this._parc = parc;
            AttractionsFileVisiteur = InitialiserDictionaire(parc);
        }

        /// <summary>
        /// Représente un dictionnaire des files d'attente des attractions du parc.
        /// Ont à choisient la Queue, car elle à un principe de file d'attente donc premier arriver premier sortie
        /// et le dictionary, car chaque Queue fait référence a une attraction et on doit pouvoir acceder a chaque
        /// file d'attente (Queue) de chaque attraction facilement.
        /// </summary>
        public Dictionary<string, Queue<Visiteur>> AttractionsFileVisiteur { get; set; }

        /// <summary>
        /// Représente les visiteurs actuellement dans le parc.
        /// Ont à choisient la LinkedList, car elle est efficace pour ajouter des données et les supprimer.
        /// comme le critère l'indique, il n'y a pas d'accès directe aux données, ce qui est le cas de la LinkedList.
        /// </summary>
        public LinkedList<Visiteur> VisiteursActuel { get; set; } = new LinkedList<Visiteur>();

        /// <summary>
        /// Permet d'ajouter un visiteur dans la file d'attente d'une attraction.
        /// </summary>
        /// <param name="attractionId">Identifiant de l'attraction.</param>
        /// <param name="visiteur">Représente un visiteur.</param>
        public void EntrerVisiteurDansFileAttente(string attractionId, Visiteur visiteur)
        {
            AttractionsFileVisiteur[attractionId].Enqueue(visiteur);
            visiteur.Historique.Add(" - Entrer dans la file d'attente de l'attraction " + attractionId);
        }

        /// <summary>
        /// Permet de faire entrer un visiteur dans une attraction.
        /// </summary>
        /// <param name="attractionId">Identifiant de l'attraction.</param>
        public void EntrerVisiteurDansAttraction(string attractionId)
        {
            AttractionsFileVisiteur[attractionId].Dequeue().Historique.Add(" - Entrer dans l'attraction " + attractionId);
        }

        /// <summary>
        /// Permet d'ajouter un visiteur dans le parc.
        /// </summary>
        /// <param name="visiteur">Représente un visiteur.</param>
        public void EntrerVisiteurDansParc(Visiteur visiteur)
        {
            VisiteursActuel.AddLast(visiteur);
            visiteur.Historique.Add(" - Entrez dans le parc.");
        }

        /// <summary>
        /// Permet de sortirir un visiteur du parc.
        /// </summary>
        /// <param name="visiteur">Représente un visiteur.</param>
        public void SortirVisiteurDuParc(Visiteur visiteur)
        {
            VisiteursActuel.Remove(visiteur);
            visiteur.Historique.Add(" - Sortir du parc.");
        }

        /// <summary>
        /// Permet d'initialiser le dictionnaire des files d'attente des attractions.
        /// </summary>
        /// <param name="parc">Représente le parc d'attraction.</param>
        /// <returns>Le dictionnaire initialisé.</returns>
        public Dictionary<string, Queue<Visiteur>> InitialiserDictionaire(Parc parc)
        {
            Dictionary<string, Queue<Visiteur>> attractions = new Dictionary<string, Queue<Visiteur>>();
            foreach (string attraction in parc.Attractions.Keys)
            {
                attractions.Add(attraction, new Queue<Visiteur>());
            }

            return attractions;
        }
    }
}
