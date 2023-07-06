using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample
{
    internal class Course
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)] public int CourseID { get; set; }
        public string CourseName { get; set; }
    }
}
