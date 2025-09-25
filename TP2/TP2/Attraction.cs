using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Attraction
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public Type Type { get; set; }

        public int Capacite { get; }

        public Attraction(int id, string nom, Type type)
        { 
            Id = id;
            Nom = nom;
            Type = type;
        }
    }
     public enum Type { S, I, F, T, M, R }
}
