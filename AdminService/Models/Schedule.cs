using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Models {
    public class Schedule {
        [Key, Required]
        public string Id { get; set; }

        public string Title { get; set; }

        public List<TripAppointment> Appointments { get; set; }
    }
}
