using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITrack.Models
{
    public class InventoryInitializer : DropCreateDatabaseIfModelChanges<Inventory>
    {
        protected override void Seed(Inventory context)
        {
            base.Seed(context);
        }
    }
}