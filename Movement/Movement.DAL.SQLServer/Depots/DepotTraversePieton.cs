using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.DAL.SQLServer.Depots
{
    public class DepotTraversePieton : IDepotTraversePieton
    {
        private readonly MovementDbContext _context;
        public List<TraversePieton> GetAll()
        {
            return this._context.TraversesPieton
                .ToList();
        }

        public void Post(TraversePieton p_traversePieton)
        {
            this._context.TraversesPieton
                .Add(p_traversePieton);
        }
    }
}
