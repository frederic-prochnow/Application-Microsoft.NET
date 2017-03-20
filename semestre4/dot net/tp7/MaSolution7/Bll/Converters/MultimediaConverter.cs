using Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Converters
{
    public class MultimediaConverter
    {
        public Dal.Multimedia ToDal(Bo.Multimedia multimedia)
        {
            Dal.Multimedia m = new Dal.Multimedia();
            m.AuteurId = multimedia.AuteurId;
            m.Titre = multimedia.Titre;

            switch (m.Type)
            {
                case "Inconnu":
                    m.Type = MultimediaType.Inconnu.ToString();
                    break;
                case "Film":
                    m.Type = MultimediaType.Film.ToString();
                    break;
                case "Musique":
                    m.Type = MultimediaType.Musique.ToString();
                    break;
                case "Serie":
                    m.Type = MultimediaType.Serie.ToString();
                    break;
            }
            return m;
        }

        public List<Dal.Multimedia> ToDal(List<Bo.Multimedia> multimedia)
        {
            List<Dal.Multimedia> liste = new List<Dal.Multimedia>();
            foreach (var item in multimedia)
            {
                liste.Add(ToDal(item));
            }
            return liste;
        }

        public Bo.Multimedia ToBo(Dal.Multimedia multimedia)
        {
            String type = multimedia.Type.ToString();
            if(type == "Inconnu")
                return new Bo.Multimedia(multimedia.AuteurId, multimedia.Titre, MultimediaType.Inconnu);
            if (type == "Film")
                return new Bo.Multimedia(multimedia.AuteurId, multimedia.Titre, MultimediaType.Film);
            if (type == "Serie")
                return new Bo.Multimedia(multimedia.AuteurId, multimedia.Titre, MultimediaType.Serie);
            if (type == "Musique")
                return new Bo.Multimedia(multimedia.AuteurId, multimedia.Titre, MultimediaType.Musique);
        }

        public List<Bo.Multimedia> ToBo(List<Dal.Multimedia> multimedia)
        {
            List<Bo.Multimedia> liste = new List<Bo.Multimedia>();
            foreach (var item in multimedia)
            {
                liste.Add(ToBo(item));
            }
            return liste;
        }
    }
}
