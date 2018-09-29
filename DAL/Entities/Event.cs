using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Event : Entity
    {
  
        [Key]
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }

        public int EventTypeId { get; set; }
        public int AssetId { get; set; }
        public int StaffId { get; set; }

        [ForeignKey("EventTypeId")]
        public EventType EventTypes { get; set; }

        [ForeignKey("AssetId")]
        public Asset Assets { get; set; }

        [ForeignKey("StaffId")]
        public Staff Staff { get; set; }

    }
}
