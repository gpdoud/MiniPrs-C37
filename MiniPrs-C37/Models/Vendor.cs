using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPrs_C37.Models {
    [Index(nameof(Code), IsUnique = true)]
    public class Vendor {
        public int Id { get; set; }
        [StringLength(30)]
        public string Code { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Address { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(5)]
        public string Zip { get; set; }
        [StringLength(12)]
        public string? Phone { get; set; }
        [StringLength(120)]
        public string? Email { get; set; }
    }
}
