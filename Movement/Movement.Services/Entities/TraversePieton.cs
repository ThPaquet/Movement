using Microsoft.EntityFrameworkCore;

namespace Movement.Services.Entities
{
    public class TraversePieton
    {
        public int Id { get; set; }
        public TypeUtilisateur TypeUtilisateur { get; set; }
        public DateTime Date { get; set; }
        public Borne BorneDepart { get; set; }
        public Borne BorneArrivee { get; set; }
        public Byte DureeEnSecondes { get; set; }
    }
}

