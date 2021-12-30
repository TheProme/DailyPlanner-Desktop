using DailyPlanner.DAL.EF.DbContexts;
using DailyPlanner.DAL.EF.Interfaces;
using DailyPlanner.DAL.EF.Models;
using DailyPlanner.DAL.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly PlannerDbContext PlannerContext;

        public IRepository<DailyEvent> DailyEvents { get; }

        public UnitOfWork(PlannerDbContext context)
        {
            PlannerContext = context ?? throw new ArgumentNullException(nameof(context));
            DailyEvents = new DailyEventRepository(PlannerContext);
        }

        public void SaveChanges()
        {
            DailyEvents.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await DailyEvents.SaveChangesAsync();
        }

        public void Dispose()
        {
            PlannerContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
