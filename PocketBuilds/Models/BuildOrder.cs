using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PocketBuilds.Models
{
    public class BuildOrder
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string Content { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}