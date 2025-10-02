using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class GestionVisiteurs
    {
        private Parc Parc;
        public Dictionary<string, Queue<Visiteur>> attractionsFileVisiteur { get; set; }
        public GestionVisiteurs(Parc parc) 
        {
            this.Parc = parc;
            attractionsFileVisiteur = InitialiserDictionaire();
        }
        public LinkedList<Visiteur> VisiteursActuel { get; set; } = new LinkedList<Visiteur>();

        //public Queue<Visiteur> VisiteursFileAttente { get; set; } = new Queue<Visiteur>();

        public void EntrerVisiteurDansFileAttente(string attractionId, Visiteur visiteur)
        {
           
            attractionsFileVisiteur[attractionId].Enqueue(visiteur);              
            visiteur.Historique.Add(" - Entrer dans la file d'attente de l'attraction " + attractionId);
        }
        public void EntrerVisiteurDansAttraction(string attractionId)
        {
            attractionsFileVisiteur[attractionId].Dequeue().Historique.Add(" - Entrer dans l'attraction " + attractionId);
        }
        public void EntrerVisiteurDansParc(Visiteur visiteur)
        { 
            VisiteursActuel.AddLast(visiteur);
            visiteur.Historique.Add(" - Entrez dans le parc.");
        }
        public void SortirVisiteurDuParc(Visiteur visiteur)
        {
            VisiteursActuel.Remove(visiteur);
            visiteur.Historique.Add(" - Sortir du parc.");
        }

        public Dictionary<string, Queue<Visiteur>> InitialiserDictionaire()
        {
            Dictionary<string, Queue<Visiteur>> attractions = new Dictionary<string, Queue<Visiteur>>();
            foreach (string attraction in Parc.Attractions.Keys)
            {
                attractions.Add(attraction, new Queue<Visiteur>());
            }
            return attractions;
        }


    }
}
