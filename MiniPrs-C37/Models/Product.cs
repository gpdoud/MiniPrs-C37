using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPrs_C37.Models {
    [Index(nameof(PartNbr), IsUnique = true)]
    public class Product {
        public int Id { get; set; }
        [StringLength(30)]
        public string PartNbr { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public string? Photopath { get; set; }
        
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
