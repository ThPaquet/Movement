using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movement.Services.Entities;

namespace Movement.Services.DepotInterfaces
{
    public interface IDepotIntersection
    {
        public List<Intersection> GetAll();
        public Intersection GetIntersectionById(int p_intersectionId);
        public void Post(Intersection p_Intersection);
        public void Put(Intersection p_Intersection);
    }
}
