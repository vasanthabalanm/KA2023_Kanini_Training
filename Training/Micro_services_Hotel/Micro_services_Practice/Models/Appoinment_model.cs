using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Appoinment_model
    {
        [Key]
        public int? AppointmentId { get; set; }

        [ForeignKey("AdminDoctor_Model")]
        public int? Id { get; set; }
        public string? Specialization { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public string? Problem { get; set; }
        public Int64? Phone { get; set; }
        public string? Location { get; set; }
        public string? Gender { get; set; }
    }
}
