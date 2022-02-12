using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.Services.Entities
{
    public class InferenceTraversePieton
    {
        public int Id { get; set; }
        public Intersection Intersection { get; set; }
        public TypeTransport TypeTransport { get; set; }
        public DateTime Date { get; set; }
        public Borne BorneDepart { get; set; }
        public Borne BorneArrivee { get; set; }
        public Byte DureeEnSecondes { get; set; }
    }
}
