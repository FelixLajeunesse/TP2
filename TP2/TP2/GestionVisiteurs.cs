using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class GestionVisiteurs
    {
        public LinkedList<Visiteur> visiteursActuel { get; set; } = new LinkedList<Visiteur>();

        public Queue<Visiteur> visiteursFileAttente { get; set; } = new Queue<Visiteur>();

        public void EntrerVisiteurDansFileAttente(string attractionId, Visiteur visiteur)
        {
            visiteursFileAttente.Enqueue(visiteur);
            visiteur.historique.Add(" - Entrer dans la file d'attente de l'attraction " + attractionId);
        }
        public void EntrerVisiteurDansAttraction(string attractionId)
        {
             visiteursFileAttente.Dequeue().historique.Add(" - Entrer dans l'attraction " + attractionId );
        }
        public void EntrerVisiteurDansParc(Visiteur visiteur)
        { 
            visiteursActuel.AddLast(visiteur);
            visiteur.historique.Add(" - Entrez dans le parc.");
        }
        public void SortirVisiteurDuParc(Visiteur visiteur)
        {
            visiteursActuel.Remove(visiteur);
            visiteur.historique.Add(" - Sortir du parc.");
        }


    }
}
