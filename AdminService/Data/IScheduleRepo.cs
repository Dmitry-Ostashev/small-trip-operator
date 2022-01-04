using System.Collections.Generic;
using AdminService.Models;

namespace AdminService.Data {
    public interface IScheduleRepo {
        bool SaveChanges();

        IEnumerable<Schedule> GetAllSchedules();

        Schedule GetScheduleById(int id);

        void CreateSchedule(Schedule schedule);
    }
}