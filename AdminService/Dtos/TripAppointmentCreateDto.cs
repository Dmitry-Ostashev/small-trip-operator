using System;

namespace AdminService.Dtos {
    public class TripAppointmentCreateDto {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
