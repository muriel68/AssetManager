using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Contact : Entity
    {
        public Contact()
        {
            this.Sites = new HashSet<Site>();
            this.Suppliers = new HashSet<Supplier>();
            this.Staffs = new HashSet<Staff>();
        }

        public int ContactId { get; set; }
        public string Name { get; set; }


        public int ContactTypeId { get; set; }
        [ForeignKey("ContactTypeId")]
        public ContactType ContactType { get; set; }

        public ICollection<Site> Sites { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }

        public ICollection<Staff> Staffs { get; set; }
    }
}
