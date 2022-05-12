using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPrs_C37.Models {
    [Index(nameof(Username), IsUnique = true)]
    public class User {
        public int Id { get; set; }
        [StringLength(30)]
        public string Username { get; set; }
        [StringLength(30)]
        public string Password { get; set; }
        [StringLength(30)]
        public string Firstname { get; set; }
        [StringLength(30)]
        public string Lastname { get; set; }
        [StringLength(12)]
        public string? Phone { get; set; }
        [StringLength(120)]
        public string? Email { get; set; }
        public bool IsReviewer { get; set; }
        public bool IsAdmin { get; set; }

        public override string ToString() {
            return $"{Id,3} {Username,-5} {Password,-5} {(IsReviewer ? "REV" : "NRV")} {(IsAdmin ? "ADM" : "NAD")} {Firstname + " " + Lastname,-40}";
        }
    }
}
