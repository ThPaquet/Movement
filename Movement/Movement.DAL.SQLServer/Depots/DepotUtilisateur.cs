using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movement.Services.DepotInterfaces;
using Movement.Services.Entities;

namespace Movement.DAL.SQLServer.Depots
{
    public class DepotUtilisateur : IDepotUtilisateur
    {
        private readonly MovementDbContext _context;

        public List<Utilisateur> GetAll()
        {
            return this._context.Utilisateurs.ToList();
        }

        public Utilisateur GetUtilisateurById(int p_Id)
        {
            return this._context.Utilisateurs.Single(utilisateur => utilisateur.Id == p_Id);
        }

        public void Post(Utilisateur p_utilisateur)
        {
            this._context.Utilisateurs.Add(p_utilisateur);
        }

        public void Put(Utilisateur p_utilisateur)
        {
            Utilisateur utilisateur = this._context.Utilisateurs.Single(utilisateur => utilisateur.Id == p_utilisateur.Id);
            if (utilisateur != null)
            {
                utilisateur.TypeUtilisateur = p_utilisateur.TypeUtilisateur;
                utilisateur.Cle = p_utilisateur.Cle;
                this._context.Utilisateurs.Update(utilisateur);
                this._context.SaveChanges();
            }
        }
    }
}
