using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebEf.Services
{
    public class Studentsas
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.None)] public int StuID { get; set; }
        public string StudName { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public int Pin { get; set; }
    }
}
