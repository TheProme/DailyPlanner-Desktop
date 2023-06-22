using DailyPlanner.Commands;
using DailyPlanner.DAL;
using DailyPlanner.DAL.EF.Models;
using DailyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DailyPlanner.ViewModels
{
    public class DailyEventViewModel: BaseViewModel
    {
        

        private DailyEventModel _initialSelectedEventState = new DailyEventModel();

        private DailyEventModel _selectedEvent;
        public DailyEventModel SelectedEvent
        {
            get => _selectedEvent;
            set
            {
                _selectedEvent = value;
                _selectedEvent.CopyTo(_initialSelectedEventState);
                OnPropertyChanged();
            }
        }
        private DailyEventWorker<DailyEvent> _dailyEventWorker;
        public ObservableCollection<DailyEventModel> DailyEvents { get; set; }

        private ICommand _updateCommand;
        public ICommand UpdateCommand => _updateCommand ??
                    (_updateCommand = new RelayCommand(obj => { _ = UpdateDailyEvent(SelectedEvent.CastToDbModel()); }));

        private ICommand _undoCommand;
        public ICommand UndoCommand => _undoCommand ??
                    (_undoCommand = new RelayCommand(obj => { UndoChangesToDailyEvent(); }));

        private void UndoChangesToDailyEvent()
        {
            _initialSelectedEventState.CopyTo(SelectedEvent);
        }

        private async Task UpdateDailyEvent(DailyEvent item)
        {
            _dailyEventWorker.UpdateData(item);
            SelectedEvent.CopyTo(_initialSelectedEventState);
            await _dailyEventWorker.SaveChangesAsync();
        }

        public DailyEventViewModel(DailyEventWorker<DailyEvent> dailyEventWorker)
        {
            _dailyEventWorker = dailyEventWorker;
            DailyEvents = new ObservableCollection<DailyEventModel>(dailyEventWorker.CastDbEventsToModelsList(dailyEventWorker.GetAll()));
        }
    }
}
