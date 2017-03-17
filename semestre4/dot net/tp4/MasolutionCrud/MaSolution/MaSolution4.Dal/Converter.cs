using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSolution4.Dal
{
    public static class Converter
    {
        public static PersonneData.PersonneDao ToDao(this MaSolution4.Bo.Personne personne)
        {
            return new PersonneData.PersonneDao
            {
                Identifiant = personne.Identifiant,
                Nom = personne.Nom,
                Prenom = personne.Prenom,
                DateNaissance = personne.DateNaissance
            };
        }
        public static List<PersonneData.PersonneDao> ToDao(this List<MaSolution4.Bo.Personne> personnes)
        {
            List<PersonneData.PersonneDao> result = new List<PersonneData.PersonneDao>();
            foreach (var item in personnes)
            {
                result.Add(item.ToDao());
            }
            return result;
        }
        public static MaSolution4.Bo.Personne ToBo(this PersonneData.PersonneDao personne)
        {
            return new MaSolution4.Bo.Personne
            {
                Identifiant = personne.Identifiant,
                Nom = personne.Nom,
                Prenom = personne.Prenom,
                DateNaissance = personne.DateNaissance
            };
        }
        public static List<MaSolution4.Bo.Personne> ToBo(this List<PersonneData.PersonneDao>
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
