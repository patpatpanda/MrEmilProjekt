using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrEmilProjekt.Data
{
    public class DataSeeder
    {
        public void MigrateAndSeed(AppDbContext myContext)
        {
            myContext.Database.Migrate();
            myContext.SaveChanges();
        }
    }
}
