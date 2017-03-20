using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Bll.Managers
{
    class MultimediaManager
    {
        public List<Multimedia> GetMultimedia()
        {
            var manager = new Managers.MultimediaManager();
            return manager.GetMultimedia();
        }
        public Multimedia GetMultimedia(long id)
        {
            var manager = new Managers.MultimediaManager();
            return manager.GetMultimedia(id);
        }
        public void AddMultimedia(Multimedia multimedia)
        {
            var manager = new Managers.MultimediaManager();
            manager.AddMultimedia(multimedia);
        }
        public void DeleteMultimedia(long id)
        {
            var manager = new Managers.MultimediaManager();
            manager.DeleteMultimedia(id);
        }
    }
}
