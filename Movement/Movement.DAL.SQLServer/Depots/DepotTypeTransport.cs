using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.DAL.SQLServer.Depots
{
    public class DepotTypeTransport : IDepotTypeTransport
    {
        private readonly MovementDbContext _context;

        public List<TypeTransport> GetAll()
        {
            return this._context.TypesTransport.ToList();
        }

        public void Post(TypeTransport p_TypeTransport)
        {
            this._context.TypesTransport.Add(p_TypeTransport);
        }

        public void Put(TypeTransport p_TypeTransport)
        {
            TypeTransport type = this._context.TypesTransport.Single(type => type.Id == p_TypeTransport.Id);
            if (type != null)
            {
                type.Type = p_TypeTransport.Type;
                this._context.TypesTransport.Update(type);
                this._context.SaveChanges();
            }
        }
    }
}
