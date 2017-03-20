using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bo;
using System.Runtime.Serialization;

namespace Service
{
    [DataContract]
    public class Multimedia
    {
        [DataMember]
        public long AuteurId { get; set; }
        [DataMember]
        public string Titre { get; set; }
        [DataMember]
        public MultimediaType Type { get; set; }

        public Multimedia(long AuteurId, string Titre, MultimediaType Type)
        {
            this.AuteurId = AuteurId;
            this.Titre = Titre;
            this.Type = Type;
        }
    }
}