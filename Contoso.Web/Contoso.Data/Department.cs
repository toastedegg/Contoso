using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Contoso.Data
{
    public class Department
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public Int64 Budget { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        [MaxLength(20)]
        public string RowVersion { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        [MaxLength(20)]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set;}

        [Required]
        [MaxLength(20)]
        public string UpdatedBy { get; set;}


        //instructor
        [Required]
        public ICollection<Instructor> Instructors;
    

    }
}
