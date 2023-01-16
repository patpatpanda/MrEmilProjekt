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
                    Height = 10,
                    Lenght = 5,
                    Area = 50,
                    Perimeter = 30,
                    Date = DateTime.Now

                });
                myContext.Shapes.Add(new Shape()
                {
                    Name = "Paraellogram",
                    Lenght = 10,
                    Height = 5,
                    Area = 50,
                    Perimeter = 30,
                    Date = DateTime.Now

                });
                myContext.Shapes.Add(new Shape()
                {
                    Name = "Triangle",
                    Area = 25,
                    Lenght = 10,
                    Height = 5,
                    Perimeter = 10,
                    Date = DateTime.Now

                });
                myContext.Shapes.Add(new Shape()
                {
                    Name = "Romb.....",
                    Height = 10,
                    Lenght = 5,
                    Area = 50,
                    Perimeter = 30,
                    Date = DateTime.Now

                });

            }
        }

    }
}
