using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TP2
{
    public class Parc
    {
        public Parc()
        {
            this.Attractions = ChargerAttractions();
        }
        //a modifier pour prendre les attractions du fichier texte.
        public List<Attraction> Attractions { get; } = [];


        private List<Attraction> ChargerAttractions()
        {
            List<Attraction> attractions = new List<Attraction>();

            string path = "attractions.txt";

            string[] text = File.ReadAllLines(path);

            foreach (string line in text)
            {
                string[] textPart = line.Split(';');

                string id = textPart[0];
                char lettre = Convert.ToChar(textPart[1]);
                Type type;
                string nom = textPart[2];
                int capacite = int.Parse(textPart[3]);


                if (lettre == 'S')
                {
                    type = Type.S;
                }
                else if (lettre == 'I')
                {
                    type = Type.I;
                }
                else if (lettre == 'R')
                {
                    type = Type.R;
                }
                else if (lettre == 'T')
                {
                    type = Type.T;
                }
                else if (lettre == 'F')
                {
                    type = Type.F;
                }
                else if (lettre == 'M')
                {
                    type = Type.M;
                }
                else
                {
                    throw new Exception("Il n'y a pas d'attraction de ce type dans le parc");
                }

                attractions.Add(new Attraction(id, nom, type, capacite));
            }
            return attractions;
        }

    }
}
