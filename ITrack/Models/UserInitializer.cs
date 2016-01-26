using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITrack.Models
{
    public class UserInitializer : DropCreateDatabaseIfModelChanges<User>
    {
        protected override void Seed(User context)
        {
            base.Seed(context);
        }
    }
}