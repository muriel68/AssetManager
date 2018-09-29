using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class ContactType : Entity
    {
        public int ContactTypeId { get; set; }
        public string ContactName { get; set; }
    }
}
