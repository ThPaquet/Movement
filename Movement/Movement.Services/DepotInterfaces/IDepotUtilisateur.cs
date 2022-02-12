using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movement.Services.Entities;

namespace Movement.Services.DepotInterfaces
{
    public interface IDepotUtilisateur
    {
        public List<Utilisateur> GetAll();
        public Utilisateur GetUtilisateurById(int p_Id);
        public void Post(Utilisateur p_utilisateur);
        public void Put(Utilisateur p_utilisateur);
    }
}
