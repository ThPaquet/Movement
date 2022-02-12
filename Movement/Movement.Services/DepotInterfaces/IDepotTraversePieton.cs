using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.Services.DepotInterfaces
{
    public interface IDepotTraversePieton
    {
        public List<TraversePieton> GetAll();
        public List<TraversePieton> GetTraverseByIntersectionId(int p_intersectionId);
        public void Post(TraversePieton p_traversePieton);
    }
}
