using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Visiteur
    {
        public string Nom { get; set; }

        public List<string> historique { get; set; } = [];

        public Visiteur(string nom)
        {
            Nom = nom;
        }
    }
}
