using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.DAL.SQLServer.Depots
{
    public class DepotInferenceTraverseVehicule : IDepotInferenceTraverseVehicule
    {
        public List<InferenceTraverseVehicule> GetAll()
        {
            throw new NotImplementedException();
        }

        public InferenceTraverseVehicule GetInference(int p_IdBorne, string p_typeUtilisateur)
        {
            throw new NotImplementedException();
        }

        public void Post(InferenceTraverseVehicule p_inferenceTraverseVehicule)
        {
            throw new NotImplementedException();
        }

        public void Put(InferenceTraverseVehicule p_inferenceTraverseVehicule)
        {
            throw new NotImplementedException();
        }
    }
}
