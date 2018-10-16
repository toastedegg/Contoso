using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class Role
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(20)]
        [Required]
        public string RoleName { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime CreatedTime { get; set; }
        [Required]
        [MaxLength(20)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime UpdatedTime { get; set; }
        [Required]
        [MaxLength(20)]
        public string UpdatedBy { get; set; }
    }
}
