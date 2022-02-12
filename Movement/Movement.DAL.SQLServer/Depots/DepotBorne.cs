using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.DAL.SQLServer.Depots
{
    public class DepotBorne : IDepotBorne
    {
        private readonly MovementDbContext _context;

        public List<Borne> GetAll()
        {
            return this._context.Bornes.ToList();
        }

        public List<Borne> GetBorneByIntersectionId(int p_intersectionId)
        {
            return this._context.Bornes.Where(borne => borne.Intersection.Id == p_intersectionId).ToList();
        }

        public void Post(Borne p_Borne)
        {
            this._context.Bornes.Add(p_Borne);
        }

        public void Put(Borne p_Borne)
        {
            Borne borne = this._context.Bornes.Where(borne => borne.Id == p_Borne.Id).FirstOrDefault();

            if (borne != null)
            {
                borne.Intersection = p_Borne.Intersection;
                borne.Longitude = p_Borne.Longitude;
                borne.Latitude = p_Borne.Latitude;
                this._context.Update(borne);
                this._context.SaveChanges();
            }
        }
    }
}
