using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movement.Services.Entities;

namespace Movement.Services.DepotInterfaces
{
    public interface IDepotActionFeu
    {
        public List<ActionFeu> GetAll();
        public void Post(ActionFeu p_ActionFeu);
        public void Put(ActionFeu p_ActionFeu);
    }
}
