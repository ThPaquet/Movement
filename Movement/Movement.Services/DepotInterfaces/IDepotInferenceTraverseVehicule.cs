using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movement.Services.Entities;

namespace Movement.Services.DepotInterfaces
{
    public interface IDepotInferenceTraverseVehicule
    {
        public List<InferenceTraverseVehicule> GetAll();
        public InferenceTraverseVehicule GetInference(int p_IdBorne, string p_typeUtilisateur);
        public void Post(InferenceTraverseVehicule p_inferenceTraverseVehicule);
        public void Put(InferenceTraverseVehicule p_inferenceTraverseVehicule);
    }
}
