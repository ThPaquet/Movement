using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.Services.DepotInterfaces
{
    public interface IDepotTypeTransport
    {
        public List<TypeTransport> GetAll();
        public void Post(TypeTransport p_ActionFeu);
        public void Put(TypeTransport p_ActionFeu);
    }
}
