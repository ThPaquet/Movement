using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.Services.Entities
{
    public class Evenement
    {
        public int Id { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public Intersection Intersection { get; set; }
        public ActionFeu Action { get; set; }
        public DateTime Date { get; set; }
    }
}
