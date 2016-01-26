using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITrack.Models
{
    public class RolesInitializer : DropCreateDatabaseIfModelChanges<Roles>
    {
        protected override void Seed(Roles context)
        {
            base.Seed(context);
        }
    }
}