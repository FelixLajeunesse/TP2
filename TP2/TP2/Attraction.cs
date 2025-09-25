using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Attraction
    {
        private int _id { get; set; }
        private string _nom { get; set; }
        private Type _type { get; set; }

        public Attraction(int id, string nom, Type type)
        { 
            this._id = id;
            this._nom = nom;
            this._type = type;
        }
    }
    enum Type { S, I, F, T, M, R }
}
