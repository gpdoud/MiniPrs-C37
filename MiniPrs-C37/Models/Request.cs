﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPrs_C37.Models {
    public class Request {
        public int Id { get; set; }
        [StringLength(80)]
        public string Description { get; set; }
        [StringLength(80)]
        public string Justification { get; set; }
        [StringLength(80)]
        public string? RejectionReason { get; set; }
        [StringLength(30)]
        public string DeliveryMode { get; set; }
        [StringLength(30)]
        public string Status { get; set; } = "NEW";
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; } = 0;

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
