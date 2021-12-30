using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.DAL.EF.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T GetByName(string name);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        void AddRange(IEnumerable<T> items);
        void UpdateRange(IEnumerable<T> items);
        void DeleteRange(IEnumerable<T> items);
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
