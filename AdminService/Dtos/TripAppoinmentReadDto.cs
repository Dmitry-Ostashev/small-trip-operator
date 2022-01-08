
using System;

namespace AdminService.Dtos {
    public class TripAppointmentReadDto {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public TripDescriptionReadDto TripDescription { get; set; }
    }
}
