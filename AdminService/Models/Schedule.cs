using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Models {
    public class Schedule {
        [Key, Required]
        public int Id { get; set; }

        public string Title { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public List<TripAppointment> Appointments { get; set; }
    }
}
