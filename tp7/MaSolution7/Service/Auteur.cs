using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Service
{
    [DataContract]
    public class Auteur
    {
        [DataMember]
        public string NomArtiste { get; set; }
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public string Prenom { get; set; }
        [DataMember]
        public List<Multimedia> Multimedia { get; set; }

        public Auteur(string NomArtiste, string Nom, string Prenom)
        {
            this.NomArtiste = NomArtiste;
            this.Nom = Nom;
            this.Prenom = Prenom;
        }
    }
}