using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class People
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(20)]
        [Required]
        public string LastName { get; set; }
        [MaxLength(20)]
        [Required]
        public string FirstName { get; set;}
        [MaxLength(20)]
        public string MiddleName { get; set; }
        [MaxLength(40)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(20)]
        [Required]
        public string AddressLine1 { get; set; }
        [MaxLength(20)]
        public string AddressLine2 { get; set; }
        public Byte UnitOrApartmentNumber { get; set; }
        [MaxLength(20)]
        [Required]
        public string City { get; set; }
        [MaxLength(20)]
        [Required]
        public string State { get; set; }
        [MaxLength(10)]
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [MaxLength(20)]
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime UpdatedDate { get; set; }
        [MaxLength(20)]
        [Required]
        public string UpdatedBy { get; set; }
        [MaxLength(20)]
        [Required]
        public string Password { get; set; }
        [Required]
        public bool Salt { get; set; }
        [Required]
        public bool IsLocked { get; set; }
        public DateTime LastLockedDateTime { get; set; }
        [Required]
        public int FailAttempts { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
    }
}
