using EntityFrameWorkAssignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkAssignment
{
    public class DemoDbContext : DbContext


    {
        public DbSet<ItemMaster> ItemMasters { get; set; }
        public DbSet<CustomerMaster> CustomerMasters { get; set; }



        public DemoDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-70LPGGG\MSSQLSERVER01;Database=Study;Trusted_Connection=True;");

        }

    }
}
