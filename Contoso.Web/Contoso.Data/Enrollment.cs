using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Data
{
    public class Enrollment
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public int StudentId { get; set; }
        [MaxLength(2)]
        public string Grade { get; set; }
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

        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        [ForeignKey("CourseId")]
        public Course  Course { get; set; }
    }
}
