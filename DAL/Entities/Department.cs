﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Department : Entity
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location Location { get; set; }
    }
}
