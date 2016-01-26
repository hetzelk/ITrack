using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITrack.Models
{
    public class TicketsInitializer : DropCreateDatabaseIfModelChanges<Tickets>
    {
        protected override void Seed(Tickets context)
        {
            base.Seed(context);
        }
    }
}