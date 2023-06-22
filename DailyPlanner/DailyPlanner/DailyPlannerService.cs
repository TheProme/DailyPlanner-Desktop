using DailyPlanner.DAL;
using DailyPlanner.DAL.EF.Models;
using DailyPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner
{
    public class DailyPlannerService
    {
        public UsersWorker<User> UsersWorker { get; private set; }
        public DailyEventWorker<DailyEvent> EventsWorker { get; private set; }

        private readonly UnitOfWork _plannerUOW;
        public DailyPlannerService(UnitOfWork plannerUOW)
        {
            _plannerUOW = plannerUOW;
            UsersWorker = new UsersWorker<User>(_plannerUOW);
            EventsWorker = new DailyEventWorker<DailyEvent>(_plannerUOW);
        }
    }
}
