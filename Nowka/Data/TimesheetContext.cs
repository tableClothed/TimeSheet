using Microsoft.EntityFrameworkCore;
using Nowka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nowka.Data
{
    public class TimesheetContext : DbContext
    {
        public TimesheetContext()
        {
        }

        public TimesheetContext(DbContextOptions<TimesheetContext> options)
            : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().ToTable("Project");
            modelBuilder.Entity<Worker>().ToTable("Worker");
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<Status>().ToTable("Status");
            modelBuilder.Entity<Timesheet>().ToTable("Timesheet");
        }
    }
}
