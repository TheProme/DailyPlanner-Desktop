using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.DAL
{
    public interface IDailyPlannerOperations<T> where T : class
    {
        IEnumerable<T> GetAll();
        void AddData(List<T> items);
        void AddData(T item);
        void DeleteData(List<T> items);
        void DeleteData(T item);
        void UpdateData(List<T> items);
        void UpdateData(T item);

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
