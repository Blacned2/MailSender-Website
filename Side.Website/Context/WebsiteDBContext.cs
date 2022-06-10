using Microsoft.EntityFrameworkCore;
using Side.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Side.Website.Context
{
    public class WebsiteDBContext : DbContext
    {
        public WebsiteDBContext(DbContextOptions options) : base(options)
        {

        }

        #region DbSets
        public DbSet<Jury> Juries { get; set; }
        public DbSet<School> Schools{ get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<GraduateStatus> GraduateStatuses { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
