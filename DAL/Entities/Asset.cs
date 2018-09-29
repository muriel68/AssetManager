using System.ComponentModel.DataAnnotations;
using DAL.Interfaces;

namespace DAL.Entities
{
    public class Asset : Entity
    {
        [Key]
        public int AssetID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}