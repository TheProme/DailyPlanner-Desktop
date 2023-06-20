using DailyPlanner.DAL.EF.DbContexts;
using DailyPlanner.DAL.EF.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DailyPlanner.DAL.EF.DbContexts
{
    public class PlannerDbContext: DbContext
    {
        public PlannerDbContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<DailyEvent> DailyEvents => Set<DailyEvent>();
        public DbSet<User> Users => Set<User>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DailyPlannerDB"].ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
