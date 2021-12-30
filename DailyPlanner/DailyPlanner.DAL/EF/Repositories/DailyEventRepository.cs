using DailyPlanner.DAL.EF.DbContexts;
using DailyPlanner.DAL.EF.Interfaces;
using DailyPlanner.DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.DAL.EF.Repositories
{
    public class DailyEventRepository : IRepository<DailyEvent>
    {
        private readonly PlannerDbContext _plannerContext;
        public DailyEventRepository(PlannerDbContext plannerContext)
        {
            _plannerContext = plannerContext;
        }

        public void Add(DailyEvent item)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<DailyEvent> items)
        {
            throw new NotImplementedException();
        }

        public void Delete(DailyEvent item)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<DailyEvent> items)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DailyEvent> GetAll()
        {
            throw new NotImplementedException();
        }

        public DailyEvent GetById(int id)
        {
            throw new NotImplementedException();
        }

        public DailyEvent GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(DailyEvent item)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<DailyEvent> items)
        {
            throw new NotImplementedException();
        }
    }
}
