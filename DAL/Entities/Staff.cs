using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos;

namespace DAL.Entities
{
   public class Staff : Entity
    {
        public Staff()
        {
            this.Contacts = new HashSet<Contact>();
        }

        [Key]
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }

        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public int? AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        [ForeignKey("ContactId")]
        public ICollection<Contact> Contacts { get; set; }
    }
}
