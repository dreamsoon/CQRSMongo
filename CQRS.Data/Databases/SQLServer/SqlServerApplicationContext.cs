
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Data.Databases.SQLServer
{
    public class SqlServerApplicationContext : DbContext, IApplicationDbContext
    {
        public SqlServerApplicationContext(DbContextOptions option)
            : base(option)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CQRSDB;Integrated Security=true;");
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlServerApplicationContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

     

    }
}
