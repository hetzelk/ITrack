using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITrack.Models
{
    public class Roles : DbContext
    {
        public int ID { get; set; }
        public string Role { get; set; }
    }
}