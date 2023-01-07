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
            myContext.SaveChanges();
        }


        private void SeedRektangel(AppDbContext myContext)
        {
            if (!myContext.Shapes.Any())
            {
                myContext.Shapes.Add(new Shape()
                {
                    Name = "Triangel",
                    Base = 10,
                    Hight = 5,
                    Area = 50,
                    Circumference = 30
                });
                myContext.Shapes.Add(new Shape()
                {
                    Name = "Paraellogram",
                    Base = 10,
                    Hight = 5,
                    Area = 50,
                    Circumference = 30
                });
                myContext.Shapes.Add(new Shape()
                {
                    Name = "Rektangel",
                    Base = 10,
                    Hight = 5,
                    Area = 50,
                    Circumference = 30
                });
                myContext.Shapes.Add(new Shape()
                {
                    Name = "Romb",
                    Base = 10,
                    Hight = 5,
                    Area = 50,
                    Circumference = 30
                });
            }
        }
    }
}
