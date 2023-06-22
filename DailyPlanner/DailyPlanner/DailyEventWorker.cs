using DailyPlanner.DAL.EF.Models;
using DailyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.DAL
{
    public class DailyEventWorker<T> : IDailyPlannerOperations<T> where T : DailyEvent
    {
        private List<DailyEvent> _itemsToAdd { get; set; } = new List<DailyEvent>();
        private List<DailyEvent> _itemsToUpdate { get; set; } = new List<DailyEvent>();
        private List<DailyEvent> _itemsToDelete { get; set; } = new List<DailyEvent>();
        private readonly UnitOfWork _plannerUOW;

        public DailyEventWorker(UnitOfWork uow)
        {
            _plannerUOW = uow;
        }

        public IEnumerable<T> GetAll()
        {
            return (IEnumerable<T>)_plannerUOW.DailyEvents.GetAll();
        }

        public void AddData(List<T> items)
        {
            throw new NotImplementedException();
        }

        public void AddData(T item)
        {
            _itemsToAdd.Add(item);
        }

        public void DeleteData(List<T> items)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(T item)
        {
            _itemsToDelete.Add(item);
        }

        public void UpdateData(List<T> items)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(T item)
        {
            _itemsToUpdate.Add(item);
        }

        public void SaveChanges()
        {
            if (_itemsToAdd.Count > 0 || _itemsToDelete.Count > 0 || _itemsToUpdate.Count > 0)
            {
                ProcessTempData();
                _plannerUOW.SaveChanges();
                ClearTempData();
            }
        }

        public async Task SaveChangesAsync()
        {
            ProcessTempData();
            await _plannerUOW.SaveChangesAsync();
            ClearTempData();
        }

        private void ClearTempData()
        {
            _itemsToAdd.Clear();
            _itemsToUpdate.Clear();
            _itemsToDelete.Clear();
        }

        private void ProcessTempData()
        {
            _plannerUOW.DailyEvents.AddRange(_itemsToAdd);
            _plannerUOW.DailyEvents.UpdateRange(_itemsToUpdate);
            _plannerUOW.DailyEvents.DeleteRange(_itemsToDelete);
        }

        public List<DailyEventModel> CastDbEventsToModelsList(IEnumerable<DailyEvent> dailyEvents)
        {
            List<DailyEventModel> dailyEventModels = new List<DailyEventModel>();
            foreach (var item in dailyEvents)
            {
                dailyEventModels.Add(new DailyEventModel(item));
            }
            return dailyEventModels;
        }
    }
}
