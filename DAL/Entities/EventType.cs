using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class EventType : Entity
    {
        [Key]
        public int EventTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
