using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.DAL.SQLServer.Depots
{
    public class DepotTypeUtilisateur : IDepotTypeUtilisateur
    {
        private readonly MovementDbContext _context;

        public List<TypeUtilisateur> GetAll()
        {
            return this._context.TypesUtilisateur.ToList();
        }

        public void Post(TypeUtilisateur p_TypeUtilisateur)
        {
            this._context.TypesUtilisateur.Add(p_TypeUtilisateur);
        }

        public void Put(TypeUtilisateur p_TypeUtilisateur)
        {
            TypeUtilisateur type = this._context.TypesUtilisateur.Single(type => type.Id == p_TypeUtilisateur.Id);
            if (type != null)
            {
                type.Type = p_TypeUtilisateur.Type;
                this._context.Update(type);
                this._context.SaveChanges();
            }
        }
    }
}
