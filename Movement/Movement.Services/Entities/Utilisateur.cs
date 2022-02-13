using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.Services.Entities
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public int TypeUtilisateurId { get; set; }
        public string Cle { get; set; }
    }
}
