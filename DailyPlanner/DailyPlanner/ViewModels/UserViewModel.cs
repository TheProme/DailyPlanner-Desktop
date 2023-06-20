using DailyPlanner.DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.ViewModels
{
    public class UserViewModel: BaseViewModel
    {
        private readonly User _user;
        #region Properties
        public string Name
        {
            get => _user.Name;
            set { _user.Name = value; OnPropertyChanged(); }
        }
        public string Surname
        {
            get => _user.Surname;
            set { _user.Surname = value; OnPropertyChanged(); }
        }
        public string Email
        {
            get => _user.Email;
            set { _user.Email = value; OnPropertyChanged(); }
        }

        public string Login
        {
            get => _user.Login;
            set { _user.Login = value; OnPropertyChanged(); }
        }

        public string Password
        {
            get => _user.Password;
            set { _user.Password = value; OnPropertyChanged(); }
        }
        #endregion
        public UserViewModel(User user)
        {
            _user = user;
        }
    }
}
