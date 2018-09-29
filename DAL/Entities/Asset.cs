using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using DAL.Interfaces;

namespace DAL.Entities
{
    public class Asset : Entity
    {
        [Key]
        public int AssetId { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public string ModelNumber { get; set; }
        public string SerielNumber { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? PurchaseDate { get; set; }

        public ICollection<Event> Events { get; set; }
        public ICollection<Audit> Audits { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int? SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public int? LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location Location { get; set; }

        public int? SiteId { get; set; }
        [ForeignKey("SiteId")]
        public Site Site { get; set; }


    }
}