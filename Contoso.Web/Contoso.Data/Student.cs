using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace Contoso.Data
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }
        [ForeignKey("Id")]
        public People people { get; set; }
    }
}
