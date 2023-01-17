using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MrEmilProjekt.Game;
using MrEmilProjekt.Shapes;
using ClassLibrary2;
using MyClassLibrary;

namespace MrEmilProjekt.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Shape> Shapes { get; set; }
        public DbSet<Calculator.Calculator> Calculators { get; set; }
        public DbSet<RockPaperScissors> Games { get; set; }

        public IMathInput _strategy { get; set; }

        public void SetStrategy(IMathInput strategy)
        {
            _strategy = strategy;
        }

        public decimal ExecuteStrategy(decimal a, decimal b)
        {
            return _strategy.Execute(a, b);
        }


        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=MrEmilProjekt;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }
    }
}
