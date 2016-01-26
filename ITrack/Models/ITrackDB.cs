using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITrack.Models
{
    public class ITrackDB : DbContext
    {
        DbSet<Roles> roles { get; set; }
    }
}