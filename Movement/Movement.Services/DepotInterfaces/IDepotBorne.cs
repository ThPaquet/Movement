using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movement.Services.Entities;

namespace Movement.Services.DepotInterfaces
{
    public interface IDepotBorne
    {
        public List<Borne> GetAll();
        public List<Borne> GetBorneByIntersectionId(int p_intersectionId);
        public void Post(Borne p_Borne);
        public void Put(Borne p_Borne);
    }
}
