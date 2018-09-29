using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class AuditType : Entity
    {
        [Key]
        public int AuditTypeId { get; set; }
        public string Name { get; set; }
    }
}
