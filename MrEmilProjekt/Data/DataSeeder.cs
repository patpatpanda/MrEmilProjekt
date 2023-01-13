using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrEmilProjekt.Shapes;

namespace MrEmilProjekt.Data
{
    public class DataSeeder
    {
        public void MigrateAndSeed(AppDbContext myContext)
        {
            myContext.Database.Migrate();
            
            SeedShape(myContext);
            myContext.SaveChanges();
        }


        public void SeedShape(AppDbContext myContext)
        {
            if (!myContext.Shapes.Any())
            {
                myContext.Shapes.Add(new Shape()
                {
                    Name = "Rectangle",
                    Area = 50,
                    Circumference = 30,
                    Date = DateTime.Now

                });
                myContext.Shapes.Add(new Shape()
                {
                    Name = "Paraellogram",
                    Area = 50,
                    Circumference = 30,
                    Date = DateTime.Now

                });
                myContext.Shapes.Add(new Shape()
                {
                    Name = "Triangle",
                    Area = 50,
                    Circumference = 30,
                    Date = DateTime.Now

                });
                myContext.Shapes.Add(new Shape()
                {
                    Name = "Romb.....",
                    Area = 50,
                    Circumference = 30,
                    Date = DateTime.Now

                });

            }
        }

    }
}
