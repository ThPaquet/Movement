using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.DAL.SQLServer.Depots
{
    internal class DepotTraverseVehicule : IDepotTraverseVehicule
    {
        private readonly MovementDbContext _context;

        public List<TraverseVehicule> GetAll()
        {
            return this._context.TraversesVehicule.ToList();
        }

        public TraverseVehicule GetTraverseByIntersectionId(int p_intersectionId)
        {
            return this._context.TraversesVehicule.Single(traverse => traverse.Id == p_intersectionId);
        }

        public void Post(TraverseVehicule p_TraverseVehicule)
        {
            this._context.TraversesVehicule.Add(p_TraverseVehicule);
        }
    }
}
