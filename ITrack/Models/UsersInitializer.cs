using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITrack.Models
{
    public class UsersInitializer : DropCreateDatabaseIfModelChanges<Users>
    {
        protected override void Seed(Users context)
        {
            base.Seed(context);
        }
    }
}