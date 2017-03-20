using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Bll.Managers
{
    class AuteurManager
    {
        public List<Auteur> GetAuteurs()
        {
            var manager = new Managers.AuteurManager();
            return manager.GetAuteurs();
        }
        public Auteur GetAuteur(long id)
        {
            var manager = new Managers.AuteurManager();
            return manager.GetAuteur(id);
        }
        public void AddAuteur(Auteur auteur)
        {
            var manager = new Managers.AuteurManager();
            manager.AddAuteur(auteur);
        }
        public void DeleteAuteur(long id)
        {
            var manager = new Managers.AuteurManager();
            manager.DeleteAuteur(id);
        }
    }
}
