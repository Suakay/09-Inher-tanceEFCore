using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherıtanceEFCore.Context
{
    internal class AppDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }  
         public DbSet<BasePerson>People { get; set; }   

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-785CG1C;Initial Catalog=Inherıtance;Integrated Security=True;TrustServerCertificate=True");

    }



}
