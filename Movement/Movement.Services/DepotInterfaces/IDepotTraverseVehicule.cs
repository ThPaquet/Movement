using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movement.Services.Entities;

namespace Movement.Services.DepotInterfaces
{
    public interface IDepotTraverseVehicule
    {
        public List<TraverseVehicule> GetAll();
        public List<TraverseVehicule> GetTraverseByIntersectionId(int p_intersectionId);
        public void Post(TraverseVehicule p_TraverseVehicule);
    }
}
