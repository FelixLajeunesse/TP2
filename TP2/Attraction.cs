using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Attraction
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public Type Type { get; set; }

        public int Capacite { get; }

        public Attraction(string id, string nom, Type type, int capacite)
        { 
            Id = id;
            Nom = nom;
            Type = type;
            Capacite = capacite;
        }
    }
     public enum Type { S, I, F, T, M, R }
}
