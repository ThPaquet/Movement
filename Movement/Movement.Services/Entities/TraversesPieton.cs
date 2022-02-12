using Microsoft.EntityFrameworkCore;

namespace Movement.Data
{
    public class TraversesPieton
    {
        public int TraversesPietonID { get; set; }
        public int IntersectionID { get; set; }
        public int TypeTransportID { get; set; }
        public DateTime Date { get; set; }
        public string Direction { get; set; }
        public int Delais { get; set; }

        public TraversesPieton()
        {

        }
    }
}

