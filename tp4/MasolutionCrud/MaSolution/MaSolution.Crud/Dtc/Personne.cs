using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSolution4.Crud.Dtc
{
    public class Personne : MaSolution4.Bo.ObjectBase
    {
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public Boolean isValid()
        {
            if (this.Nom.Length <= 5 && this.Prenom.Length <= 5)
                return true;
            return false;
        }

        public String toString()
        {
            return "Nom : " + this.Nom + "- Prenom : " 
                + this.Prenom + "- Date : " + this.DateNaissance.ToString();
        }
    }
}
