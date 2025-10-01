namespace TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parc parc = new Parc();
            Visiteur visiteur = new Visiteur("test");
            GestionVisiteurs gestionVisiteurs = new GestionVisiteurs();
            Map map = new Map();
            gestionVisiteurs.EntrerVisiteurDansParc(visiteur);
            gestionVisiteurs.EntrerVisiteurDansFileAttente(parc.Attractions[0].Id ,visiteur);
            gestionVisiteurs.EntrerVisiteurDansAttraction(parc.Attractions[0].Id);
            gestionVisiteurs.SortirVisiteurDuParc(visiteur);
            AffichageConsole.AfficherHistoriqueVisiteur(visiteur);
            gestionVisiteurs.EntrerVisiteurDansParc(visiteur);
            AffichageConsole.Afficher(parc, map, gestionVisiteurs);
            
        }
    }
}

