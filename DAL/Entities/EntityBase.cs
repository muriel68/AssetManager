using System;

namespace DAL.Entities
{
    public abstract class Entity
    {
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}