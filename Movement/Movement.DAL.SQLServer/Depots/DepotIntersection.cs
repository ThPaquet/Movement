using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.DAL.SQLServer.Depots
{
    public class DepotIntersection : IDepotIntersection
    {
        private readonly MovementDbContext _context;

        public List<Intersection> GetAll()
        {
            return this._context.Intersections.ToList();
        }

        public Intersection GetIntersectionById(int p_intersectionId)
        {
            return this._context.Intersections.Single(intersection => intersection.Id == p_intersectionId);
        }

        public void Post(Intersection p_Intersection)
        {
            this._context.Intersections.Add(p_Intersection);
        }

        public void Put(Intersection p_Intersection)
        {
            Intersection intersection = this._context.Intersections.Single(intersection => intersection.Id == p_Intersection.Id);
            if (intersection != null)
            {
                intersection.Nom = p_Intersection.Nom;
                this._context.Update(intersection);
                this._context.SaveChanges();
            }
        }
    }
}
