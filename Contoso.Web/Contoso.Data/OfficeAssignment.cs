using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Data
{
    public class OfficeAssignment
    {
        [Key]
        [Required]
        public int InstructorId { get; set; }
        [MaxLength(20)]
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        [MaxLength(20)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime UpdatedDate { get; set; }
        [Required]
        [MaxLength(20)]
        public string UpdatedBy { get; set; }

        [ForeignKey("InstructorId")]
        public Instructor Instructor;

    }
}
