using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.DAL.SQLServer.Depots
{
    public class DepotInferenceTraversePieton : IDepotInferenceTraversePieton
    {
        private readonly MovementDbContext _context;
        public List<InferenceTraversePieton> GetAll()
        {
            return this._context.InferencesTraversePieton
                .ToList();
        }

        public InferenceTraversePieton GetInference(int p_IdBorne, string p_typeUtilisateur)
        {
            return this._context.InferencesTraversePieton
                .FirstOrDefault(t =>
                    t.BorneDepart.Id == p_IdBorne && t.TypeUtilisateur.Type == p_typeUtilisateur);
        }

        public void Post(InferenceTraversePieton p_inferenceTraversePieton)
        {
            this._context.InferencesTraversePieton
                .Add(p_inferenceTraversePieton);

            this._context.SaveChanges();
        }

        public void Put(InferenceTraversePieton p_inferenceTraversePieton)
        {
            this._context.InferencesTraversePieton
                .Update(p_inferenceTraversePieton);

            this._context.SaveChanges();
        }
    }
}
