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
                    _Name = "Rectangle",
                    _Height = 10,
                    _Lenght = 5,
                    Area = 50,
                    Perimeter = 30,
                    Date = DateTime.Now
                    
                });
                myContext.Shapes.Add(new Shape()
                {
                    _Name = "Paraellogram",
                    _Lenght = 10,
                    _Height = 5,
                    Area = 50,
                    Perimeter = 30,
                    Date = DateTime.Now

                });
                myContext.Shapes.Add(new Shape()
                {
                    _Name = "Triangle",
                    Area = 25,
                    _Lenght = 10,
                    _Height = 5,
                    Perimeter = 10,
                    Date = DateTime.Now

                });
                myContext.Shapes.Add(new Shape()
                {
                    _Name = "Rhombus",
                    _Height = 10,
                    _Lenght = 5,
                    Area = 50,
                    Perimeter = 30,
                    Date = DateTime.Now

                });

            }
        }

    }
}
