using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Location : Entity
    {
        [Key]
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Description { get; set; }

        public int SiteId { get; set; }
        [ForeignKey("SiteId")]
        public Site Site { get; set; }
    }
}
