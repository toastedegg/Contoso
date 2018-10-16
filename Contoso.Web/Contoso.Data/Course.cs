using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class Course
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }
        [Required]
        public Int16 Credits { get; set; }
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

        //department
        [Required]
        public Department Department;
    }
}
