using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAspNet.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAppAspNet.Data
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Appointment> Appointment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Appointment>().ToTable("Appointment");
        }
    }
}
