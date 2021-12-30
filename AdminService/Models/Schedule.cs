using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Models {
    public class Schedule {
        public string Id { get; set; }

        public string Title { get; set; }

        public List<TripAppointment> Appointments { get; set; }
    }
}
