using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.Services.Entities
{
    public class InferenceTraverseVehicule
    {
        public int Id { get; set; }
        public Intersection Intersection { get; set; }
        public TypeTransport TypeTransport { get; set; }
        public DateTime Date { get; set; }
        public string Direction { get; set; }
    }
}
