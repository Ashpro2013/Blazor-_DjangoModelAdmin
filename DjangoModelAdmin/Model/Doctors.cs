using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DjangoModelAdmin.Model
{
    public class Doctors
    {
        [Key]
        public int doc_id { get; set; }
        public string doc_name { get; set; }
        public string doc_spec { get; set; }

        // Foreign key for Departments
        public int dep_id { get; set; }

        // Navigation property for Departments
        [ForeignKey("dep_id")]
        public Departments Department { get; set; }

        public string doc_image { get; set; }
        public ICollection<Bookings> Bookings { get; set; } = new List<Bookings>();

    }
}
