using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITrack.Models
{
    public class Companies : DbContext
    {
        public int CompaniesId { get; set; }
        public string CompanyName { get; set; }
    }
}