using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo
{
    public class Multimedia : BoBase
    {
        public long AuteurId { get; set; }
        public string Titre { get; set; }
        public MultimediaType Type { get; set; }

        public Multimedia(long AuteurId, string Titre, MultimediaType Type)
        {
            this.AuteurId = AuteurId;
            this.Titre = Titre;
            this.Type = Type;
        }

    }
}
