using PocketBuilds.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PocketBuilds.Data_Access_Layer
{
    public class BuildOrderContext : DbContext
    {
        public BuildOrderContext() : base( "BuildOrderContext" )
        {
        }

        public DbSet<BuildOrder> BuildOrders { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}