using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITrack.Models
{
    public class TrackerInitializer : DropCreateDatabaseIfModelChanges<Tracker>
    {
        protected override void Seed(Tracker context)
        {
            base.Seed(context);
        }
    }
}