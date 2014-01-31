using PocketBuilds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PocketBuilds.Data_Access_Layer
{
    public class BuildOrderInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BuildOrderContext>
    {
        protected override void Seed(BuildOrderContext context)
        {
            var BuildOrders = new List<BuildOrder>
            {
                new BuildOrder{ Title = "3 GATE ROBO", Content = "This is the first test" }, 
                new BuildOrder{ Title = "TWILIGH ALL-IN", Content = "This is the second test" }
            };
            BuildOrders.ForEach(build => context.BuildOrders.Add(build)); 
            context.SaveChanges();

            var Notes = new List<Note>
            {
                new Note{ BuildOrderID=1, Content = "the first note" },
                new Note{ BuildOrderID=2, Content = "The second note" }
            }; 
            Notes.ForEach(note => context.Notes.Add(note));
            context.SaveChanges(); 
        }
    }
}