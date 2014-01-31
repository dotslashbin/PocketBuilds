using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace PocketBuilds.Models
{
    public class Note
    {
        public int ID { get; set; }

        [Required]
        public int BuildOrderID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}