using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Converters
{
    public class AuteurConverter
    {
        public Dal.Auteur ToDal(Bo.Auteur auteur)
        {
            return new Dal.Auteur
            {
                NomArtiste = auteur.NomArtiste,
                Nom = auteur.Nom,
                Prenom = auteur.Prenom
            };
        }

        public List<Dal.Auteur> ToDal(List<Bo.Auteur> auteur)
        {
            List<Dal.Auteur> liste = new List<Dal.Auteur>();
            foreach(var item in auteur)
            {
                liste.Add(ToDal(item));
            }
            return liste;
        }

        public Bo.Auteur ToBo(Dal.Auteur auteur)
        {
            return new Bo.Auteur(auteur.NomArtiste, auteur.Nom, auteur.Prenom);
        }

        public List<Bo.Auteur> ToBo(List<Dal.Auteur> auteur)
        {
            List<Bo.Auteur> liste = new List<Bo.Auteur>();
            foreach(var item in auteur)
            {
                liste.Add(ToBo(item));
            }
            return liste;
        }
    }
}
