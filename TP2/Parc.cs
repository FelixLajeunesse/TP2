// <copyright file="Parc.cs" company="CSTJEAN">
// Félix Lajeunesse et Yoan Jalbert
// </copyright>
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    /// <summary>
    /// Cette Classe permet de représenter le parc d'attractions.
    /// </summary>
    public class Parc
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        public Parc()
        {
            this.Attractions = ChargerAttractions();
        }

        /// <summary>
        /// Représente un dictionnaire des attractions du parc.
        /// </summary>
        public Dictionary<string, Attraction> Attractions { get; } = [];

        private Dictionary<string, Attraction> ChargerAttractions()
        {
            Dictionary<string, Attraction> attractions = new Dictionary<string, Attraction>();

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

                attractions.Add(id, new Attraction(id, nom, type, capacite));
            }

            return attractions;
        }
    }
}
