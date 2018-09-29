using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Audit : Entity
    {
        [Key]
        public int AuditId { get; set; }
        public DateTime AuditDate { get; set; }
        public string Description { get; set; }

        public int AuditTypeId { get; set; }
        [ForeignKey("AuditTypeId")]
        public AuditType AuditType { get; set; }

        public int AssetId { get; set; }
        [ForeignKey("AssetId")]
        public Asset Assets { get; set; }
    }
}
