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
    public class UserRepository : IRepository<User>
    {
        private readonly PlannerDbContext _plannerContext;
        public UserRepository(PlannerDbContext plannerContext)
        {
            _plannerContext = plannerContext;
        }

        public void Add(User item)
        {
            _plannerContext.Add(item);
        }

        public void AddRange(IEnumerable<User> items)
        {
            throw new NotImplementedException();
        }

        public void Delete(User item)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<User> items)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            return _plannerContext.Users.Find(id);
        }

        public User GetByName(string name)
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

        public void Update(User item)
        {
            _plannerContext.Update(item);
        }

        public void UpdateRange(IEnumerable<User> items)
        {
            _plannerContext.UpdateRange(items);
        }
    }
}
