using System.ComponentModel.DataAnnotations;

namespace DjangoModelAdmin.Model
{
    public class Departments
    {
        [Key]
        public int dep_id { get; set; }
        public string dep_name { get; set; }
        public string dep_description { get; set; }

        // Navigation property for the related Doctors
        public ICollection<Doctors> Doctors { get; set; } = new List<Doctors>();
    }
}
