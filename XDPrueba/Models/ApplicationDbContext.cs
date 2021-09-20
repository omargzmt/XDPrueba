using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XDPrueba.Maps;
using XDPrueba.Models.BDFolder;

namespace XDPrueba.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new PersonMap(modelBuilder.Entity<Person>());
            new DepartmentMap(modelBuilder.Entity<Department>());
            new PersonDepartmentMap(modelBuilder.Entity<PersonDepartment>());
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<PersonDepartment> PersonDepartment { get; set; }
    }
}
