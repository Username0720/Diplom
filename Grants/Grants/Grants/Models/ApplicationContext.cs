using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Grants.Models
{
    class ApplicationContext : DbContext
    {
        private string _databasePath;

        public DbSet<Data_> Datas { get; set; }

        public ApplicationContext(string databasePath)
        {
            _databasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql($"Filename={_databasePath}");
        }

        //public DbSet<User> Users { get; set; }
        //public DbSet<Data> Reports { get; set; }
        //public DbSet<Subject> Services { get; set; }
        //public DbSet<User_Data> Providers { get; set; }
        //public DbSet<Subject_Data> Providers { get; set; }
        //public ApplicationContext(DbContextOptions<ApplicationContext> options)
        //    : base(options)
        //{
        //    Database.EnsureCreated();
        //}
    }
}
