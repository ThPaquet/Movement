using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.DAL.SQLServer.Depots
{
    public class DepotEvenement : IDepotEvenement
    {
        private readonly MovementDbContext _context;

        public List<Evenement> GetAll()
        {
            return this._context.Evenements.ToList();
        }

        public List<Evenement> GetEvenementByIntersectionId(int p_intersectionId)
        {
            return this._context.Evenements.Where(evenement => evenement.Intersection.Id == p_intersectionId).ToList();
        }

        public void Post(Evenement p_Evenement)
        {
            this._context.Evenements.Add(p_Evenement);
        }
    }
}
