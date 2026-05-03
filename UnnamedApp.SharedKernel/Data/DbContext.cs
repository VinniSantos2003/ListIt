using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnnamedApp.SharedKernel.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemList> ItemLists { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
           var migrations =  Database.GetPendingMigrations();
            if (migrations.Any())
            {
                Database.Migrate();
            }
        }
    }
}
