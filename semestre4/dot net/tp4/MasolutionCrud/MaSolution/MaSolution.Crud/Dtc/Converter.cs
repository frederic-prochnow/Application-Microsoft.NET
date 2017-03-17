using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSolution4.Crud.Dtc
{
    public static class Converter
    {
        public static Personne ToDtc(this MaSolution4.Bo.Personne personne)
        {
            return new Personne
            {
                Identifiant = personne.Identifiant,
                Nom = personne.Nom,
                Prenom = personne.Prenom,
                DateNaissance = personne.DateNaissance
            };
        }
        public static List<Personne> ToDao(this List<MaSolution4.Bo.Personne> personnes)
        {
            List<Personne> result = new List<Personne>();
            foreach (var item in personnes)
            {
                result.Add(item.ToDtc());
            }
            return result;
        }
        public static MaSolution4.Bo.Personne ToBo(this Personne personne)
        {
            return new MaSolution4.Bo.Personne
            {
                Identifiant = personne.Identifiant,
                Nom = personne.Nom,
                Prenom = personne.Prenom,
                DateNaissance = personne.DateNaissance
            };
        }
        public static List<MaSolution4.Bo.Personne> ToBo(this List<Personne>
personnes)
        {
            List<MaSolution4.Bo.Personne> result = new List<MaSolution4.Bo.Personne>();
            foreach (var item in personnes)
            {
                result.Add(item.ToBo());
            }
            return result;
        }
    }
}
