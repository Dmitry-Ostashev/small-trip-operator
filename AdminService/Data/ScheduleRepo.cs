using System;
using System.Collections.Generic;
using System.Linq;
using AdminService.Models;

namespace AdminService.Data {
    public class ScheduleRepo : IScheduleRepo {
        private readonly AppDbContext _context;
        public ScheduleRepo(AppDbContext context) {
            _context = context;
        }

        public bool SaveChanges() {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Schedule> GetAllSchedules() {
            return _context.Schedules.ToList();
        }

        public Schedule GetScheduleById(int id) {
            return _context.Schedules.FirstOrDefault(s => s.Id == id);
        }

        public void CreateSchedule(Schedule schedule) {
            if (schedule == null)
                throw new ArgumentNullException();

            _context.Schedules.Add(schedule);
        }
    }
}