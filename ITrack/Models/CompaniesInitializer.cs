using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITrack.Models
{
    public class CompaniesInitializer : DropCreateDatabaseIfModelChanges<Companies>
    {
        protected override void Seed(Companies context)
        {
            base.Seed(context);
        }
    }
}