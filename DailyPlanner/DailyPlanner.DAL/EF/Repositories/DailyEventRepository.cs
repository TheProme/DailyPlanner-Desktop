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
            _plannerContext.Add(item);
        }

        public void AddRange(IEnumerable<DailyEvent> items)
        {
            foreach (var item in items)
            {
                _plannerContext.Add(item);
            }
        }

        public void Delete(DailyEvent item)
        {
            _plannerContext.Remove(item);
        }

        public void DeleteRange(IEnumerable<DailyEvent> items)
        {
            foreach (var item in items)
            {
                _plannerContext.Remove(item);
            }
        }

        public IEnumerable<DailyEvent> GetAll()
        {
            return _plannerContext.DailyEvents.AsEnumerable();
        }

        public DailyEvent GetById(int id)
        {
            return _plannerContext.DailyEvents.Find(id);
        }

        public DailyEvent GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _plannerContext.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return _plannerContext.SaveChangesAsync();
        }

        public void Update(DailyEvent item)
        {
            _plannerContext.Update(item);
        }

        public void UpdateRange(IEnumerable<DailyEvent> items)
        {
            foreach (var item in items)
            {
                var existingItem = GetById(_plannerContext.DailyEvents.FirstOrDefault(i => i.ID == item.ID).ID);
                existingItem.Name = item.Name;
                existingItem.IsCompleted = item.IsCompleted;
                existingItem.Description = item.Description;
                existingItem.Date = item.Date;
            }
        }
    }
}
