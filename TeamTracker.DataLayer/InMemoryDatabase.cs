using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TeamTracker.Entities;

namespace TeamTracker.DataLayer
{
   public class InMemoryDatabase:DbContext
    {

        //Creating inmemoryDb context
        public InMemoryDatabase(DbContextOptions<InMemoryDatabase> options):base(options)
        {

        }
        //creating property of db 
        public DbSet<Teams> teams { get; set; }

        public DbSet<Users> users { get; set; }

     
    }
}
