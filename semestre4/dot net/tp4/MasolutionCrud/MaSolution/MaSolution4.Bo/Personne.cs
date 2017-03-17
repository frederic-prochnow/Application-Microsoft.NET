using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSolution4.Bo
{
    public class Personne : ObjectBase
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
    }
}
