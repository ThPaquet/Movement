using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.DAL.SQLServer.Depots
{
    public class DepotActionFeu : IDepotActionFeu
    {
        private readonly MovementDbContext _context = new MovementDbContext();

        public List<ActionFeu> GetAll()
        {
            return this._context.ActionsFeu.ToList();
        }

        public void Post(ActionFeu p_ActionFeu)
        {
            this._context.ActionsFeu.Add(p_ActionFeu);
        }

        public void Put(ActionFeu p_ActionFeu)
        {
            ActionFeu action = this._context.ActionsFeu.Where(action => action.Id == p_ActionFeu.Id).FirstOrDefault();

            if (action != null)
            {
                action.Type = p_ActionFeu.Type;
                this._context.Update(action);
                this._context.SaveChanges();
            }
        }
    }
}
