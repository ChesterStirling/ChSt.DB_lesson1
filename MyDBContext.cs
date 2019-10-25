using System;
using System.Data.Entity;

namespace ChSt.DataBases
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("DbConnectionString")
        {
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
