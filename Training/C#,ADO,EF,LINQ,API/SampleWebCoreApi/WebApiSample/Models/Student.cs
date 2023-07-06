using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiSample.Models
{
    public class Student
    {

        [Key][DatabaseGenerated(DatabaseGeneratedOption.None)] public int StuID { get; set; }
        public string StudName { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public int Pin { get; set; }
    }
}
