using MaSolution4.Crud.Dtc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSolution4.Crud.Dtc
{
    class PersonneManager
    {
        private MaSolution4.Bll.PersonneManager _PersonneManager = null;
        public PersonneManager()
        {
            _PersonneManager = new MaSolution4.Bll.PersonneManager();
        }
        public List<Personne> GetPersonnes()
        {
            return _PersonneManager.GetPersonnes().ToDao();
        }
        public MaSolution4.Bo.Personne Add(Personne personne)
        {
            return _PersonneManager.Add(personne.ToBo());
        }
        public Boolean Update(Personne personne)
        {
            return _PersonneManager.Update(personne.ToBo());
        }
        public Boolean Delete(Personne personne)
        {
            return _PersonneManager.Delete(personne.ToBo());
        }
    }
}
