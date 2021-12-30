using DailyPlanner.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner
{
    public class DailyPlannerService
    {
        private readonly UnitOfWork _plannerUOW;
        public DailyPlannerService(UnitOfWork plannerUOW)
        {
            _plannerUOW = plannerUOW;
        }

    }
}
