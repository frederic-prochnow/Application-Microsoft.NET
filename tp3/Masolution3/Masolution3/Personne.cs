using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masolution3
{
    class Personne
    {
        int Identifiant;
        string Nom;
        string Prenom;
        DateTime DateNaissance;
        List<PersonneAdresse> Adresses;

        public Personne(int Identifiant,string Nom,string Prenom,DateTime DateNaissance,List<PersonneAdresse> Adresses)
        {
            this.Identifiant = Identifiant;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.DateNaissance = DateNaissance;
            this.Adresses = Adresses;
        }
    }
}
