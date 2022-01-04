using System.Collections.Generic;
using AdminService.Models;

namespace AdminService.Data {
    public interface ITripAppointmentRepo {
        bool SaveChanges();

        IEnumerable<TripAppointment> GetAllTripAppointments();

        TripAppointment GetTripAppointmentById(int id);

        void CreateTripAppointment(TripAppointment tripAppointment);
    }
}
