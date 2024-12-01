using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DjangoModelAdmin.Model
{
    public class Bookings
    {
        [Key]
        public int booking_id { get; set; }
        public string p_name { get; set; }
        public string p_phone { get; set; }
        public string p_email { get; set; }
        public DateTime booking_date { get; set; }
        public DateTime booked_on { get; set; }
        public int doc_id { get; set; }
        [ForeignKey("doc_id")]
        public Doctors Doctor { get; set; }
    }
}
