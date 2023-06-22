using DailyPlanner.DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.Models
{
    public class DailyEventModel : INotifyPropertyChanged
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; OnPropertyChanged(); }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private bool _isCompleted;

        public bool IsCompleted
        {
            get { return _isCompleted; }
            set { _isCompleted = value; OnPropertyChanged(); }
        }

        private string? _description;

        public string? Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(); }
        }
        private int _userId;

        public int UserID
        {
            get { return _userId; }
            set { _userId = value; OnPropertyChanged(); }
        }
        private User _user;

        public User User
        {
            get { return _user; }
            set { _user = value; OnPropertyChanged(); }
        }

        public DailyEventModel()
        {

        }
        public DailyEventModel(DailyEvent dbModel)
        {
            CastToViewableModel(dbModel);
        }

        public DailyEvent CastToDbModel()
        {
            return new DailyEvent
            {
                ID = ID,
                Date = Date,
                Name = Name,
                IsCompleted = IsCompleted,
                Description = Description,
                UserID = UserID,
                User = User
            };
        }

        public void CastToViewableModel(DailyEvent dbModel)
        {
            ID = dbModel.ID;
            Date = dbModel.Date;
            Name = dbModel.Name;
            IsCompleted = dbModel.IsCompleted;
            Description = dbModel.Description;
            UserID = dbModel.UserID;
            User = dbModel.User;
        }

        public void CopyTo(DailyEventModel otherModel)
        {
            otherModel.ID = ID;
            otherModel.Date = Date;
            otherModel.Name = Name;
            otherModel.IsCompleted = IsCompleted;
            otherModel.Description = Description;
            otherModel.UserID = UserID;
            otherModel.User = User;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
