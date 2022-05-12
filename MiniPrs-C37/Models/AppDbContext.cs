using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPrs_C37.Models {
    public class AppDbContext : DbContext {
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<Requestline> Requestlines { get; set; } = null!;

        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr = @"server=localhost\sqlexpress;"
                            + "database=MiniPrs;"
                            + "trustServerCertificate=true;"
                            + "trusted_connection=true;";
            builder.UseSqlServer(connStr);
        }
    }
}
