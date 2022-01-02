using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminService.Models {
    public class TripAppointment {
        [Key, Required]
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public TripDescription TripDescription { get; set; }
    }
}
