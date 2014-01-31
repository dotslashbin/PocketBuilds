using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PocketBuilds.Models
{
    public class Note
    {
        public int ID { get; set; }
        public int BuildOrderID { get; set; }
        public string Content { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}