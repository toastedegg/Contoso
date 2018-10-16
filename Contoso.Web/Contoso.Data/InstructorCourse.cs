using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class InstructorCourse
    {
        [Required]
        [Key,Column(Order = 1)]
        public int Instructor_Id { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public int Course_Id { get; set; }
        [ForeignKey("Instructor_Id")]
        public Instructor Instructor { get; set; }
        [ForeignKey("Course_Id")]
        public Course Course { get; set; }
        
    }
}
