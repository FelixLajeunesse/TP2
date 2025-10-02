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

        public GestionVisiteurs(Parc parc) 
        {
            this.Parc = parc;   
        }   
        public LinkedList<Visiteur> VisiteursActuel { get; set; } = new LinkedList<Visiteur>();

        public Queue<Visiteur> VisiteursFileAttente { get; set; } = new Queue<Visiteur>();

        public void EntrerVisiteurDansFileAttente(string attractionId, Visiteur visiteur)
        {
            VisiteursFileAttente.Enqueue(visiteur);
            visiteur.Historique.Add(" - Entrer dans la file d'attente de l'attraction " + attractionId);
        }
        public void EntrerVisiteurDansAttraction(string attractionId)
        {
             VisiteursFileAttente.Dequeue().Historique.Add(" - Entrer dans l'attraction " + attractionId );
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


    }
}
