using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo
{
    class Auteur : BoBase
    {
        public string NomArtiste { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public List<Multimedia> Multimedia { get; set; }
    }
}
