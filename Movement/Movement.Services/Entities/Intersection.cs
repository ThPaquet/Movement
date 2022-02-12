using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.Services.Entities
{
    public class Intersection
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public List<Borne> Bornes { get; set; }

    }
}
