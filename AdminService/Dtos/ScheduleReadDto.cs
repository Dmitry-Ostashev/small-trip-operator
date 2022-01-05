using System.Collections.Generic;
using AdminService.Models;

namespace AdminService.Dtos {
    public class ScheduleReadDto {
        public int Id { get; set; }

        public string Title { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public List<TripAppointment> Appointments { get; set; }
    }
}