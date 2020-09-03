using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using tuseTheProgrammer.Models;

namespace tuseTheProgrammer.Services
{
    public class SQLDbContextDataAccess : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public SQLDbContextDataAccess(DbContextOptions<SQLDbContextDataAccess> dbContextOptions)
            :base(dbContextOptions)
        {

        }
        //Work Later....
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
