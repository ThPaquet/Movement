using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.Services.DepotInterfaces
{
    public interface IDepotTypeUtilisateur
    {
        public List<TypeUtilisateur> GetAll();
        public void Post(TypeUtilisateur p_TypeUtilisateur);
        public void Put(TypeUtilisateur p_TypeUtilisateur);
    }
}
