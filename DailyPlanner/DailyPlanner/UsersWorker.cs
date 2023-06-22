using DailyPlanner.DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.DAL
{
    public class UsersWorker<T> : IDailyPlannerOperations<T> where T : User
    {
        private List<User> _itemsToAdd { get; set; } = new List<User>();
        private List<User> _itemsToUpdate { get; set; } = new List<User>();
        private List<User> _itemsToDelete { get; set; } = new List<User>();
        private readonly UnitOfWork _plannerUOW;

        public UsersWorker(UnitOfWork uow)
        {
            _plannerUOW = uow;
        }

        public IEnumerable<T> GetAll()
        {
            return (IEnumerable<T>)_plannerUOW.Users.GetAll();
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
            _plannerUOW.Users.AddRange(_itemsToAdd);
            _plannerUOW.Users.UpdateRange(_itemsToUpdate);
            _plannerUOW.Users.DeleteRange(_itemsToDelete);
        }
    }
}
