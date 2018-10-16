using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Data
{
    public class Instructor
    {
        [Required]
        public int Id { get; set;}
        [Required]
        public DateTime HireDate { get; set;}
        [ForeignKey("Id")]
        public People people { get; set;}
        [ForeignKey("Id")]
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}
