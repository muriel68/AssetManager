﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Site : Entity
    {
        public Site()
        {
            this.Contacts = new HashSet<Contact>();
        }
        [Key]
        public int SiteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        [ForeignKey("ContactId")]
        public ICollection<Contact> Contacts { get; set; }
    }
}
