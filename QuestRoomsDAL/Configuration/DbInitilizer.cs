using QuestRoomsDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomsDAL.Configuration
{
    class DbInitilizer: DropCreateDatabaseAlways<RoomsContext>
    {
        protected override void Seed(RoomsContext context)
        {
            context.countries.Add(new Country { Name = "Taiwan" });
            context.countries.Add(new City { Name = "Katonitsa" });
            context.countries.Add(new Street { Name = "Polubotka" });
            context.countries.Add(new Address { HouseNumber = 13 });
        }
    }
}
