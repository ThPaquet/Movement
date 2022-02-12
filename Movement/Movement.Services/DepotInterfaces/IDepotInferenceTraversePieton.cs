using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.Services.DepotInterfaces
{
    public interface IDepotInferenceTraversePieton
    {
        public List<InferenceTraversePieton> GetAll();
        public InferenceTraversePieton GetInference(int p_IdBorne, string p_typeUtilisateur);
        public void Post(InferenceTraversePieton p_inferenceTraversePieton);
        public void Put(InferenceTraversePieton p_inferenceTraversePieton);
    }
}
