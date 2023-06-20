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
        public UnitOfWork PlannerUOW { get; }
        public DailyPlannerService(UnitOfWork plannerUOW)
        {
            PlannerUOW = plannerUOW;
        }

    }
}
