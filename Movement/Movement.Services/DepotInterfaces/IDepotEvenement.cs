using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movement.Services.Entities;

namespace Movement.Services.DepotInterfaces
{
    public interface IDepotEvenement
    {
        public List<Evenement> GetAll();
        public List<Evenement> GetEvenementByIntersectionId(int p_intersectionId);
        public void Post(Evenement p_Evenement);
    }
}
