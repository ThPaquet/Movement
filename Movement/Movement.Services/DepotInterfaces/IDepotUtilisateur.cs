using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movement.Services.Entities;

namespace Movement.Services.DepotInterfaces
{
    internal interface IDepotUtilisateur
    {
        public List<Utilisateur> GetAll();
        public Utilisateur GetUtilisateurById(int p_Id);
        public void Post(Borne p_Borne);
        public void Put(Borne p_Borne);
    }
}
