using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSolution4.Bll
{
    public class PersonneManager
    {
        private MaSolution4.Dal.PersonneManager Personne_Manager = null;
        public PersonneManager()
        {
            Personne_Manager = new Dal.PersonneManager();
        }
        public List<MaSolution4.Bo.Personne> GetPersonnes()
        {
            return Personne_Manager.GetPersonnes();
        }
        public MaSolution4.Bo.Personne Add(MaSolution4.Bo.Personne personne)
        {
            return Personne_Manager.Add(personne);
        }
        public Boolean Update(MaSolution4.Bo.Personne personne)
        {
            return Personne_Manager.Update(personne);
        }
        public Boolean Delete(MaSolution4.Bo.Personne personne)
        {
            return Personne_Manager.Delete(personne);
        }
    }
}
