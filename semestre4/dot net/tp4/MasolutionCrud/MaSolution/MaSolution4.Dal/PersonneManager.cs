using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonneData;
using FileDataProvider;

namespace MaSolution4.Dal
{
    public class PersonneManager
    {
        private Command<PersonneDao> _PersonneCommande = null;
        public PersonneManager()
        {
            _PersonneCommande = new Command<PersonneDao>(".\\PersonneData.xml");
        }
        public List<MaSolution4.Bo.Personne> GetPersonnes()
        {
            return _PersonneCommande.GetList().ToBo();
        }
        public MaSolution4.Bo.Personne Add(MaSolution4.Bo.Personne personne)
        {
            return _PersonneCommande.Add(personne.ToDao()).ToBo();
        }
        public Boolean Update(MaSolution4.Bo.Personne personne)
        {
            return _PersonneCommande.Update(personne.ToDao());
        }
        public Boolean Delete(MaSolution4.Bo.Personne personne)
        {
            return _PersonneCommande.Delete(personne.ToDao());
        }
    }
}
