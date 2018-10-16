using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Data
{
    public class PersonRole
    {
        [Required]
        [Key,Column(Order = 1)]
        public int Person_Id { get; set; }
        [Required]
        [Key,Column(Order = 2)]
        public int Role_Id { get; set; }
        [ForeignKey("Person_Id")]
        public People people { get; set; }
        [ForeignKey("Role_Id")]
        public Role Role { get; set; }
    }
}
