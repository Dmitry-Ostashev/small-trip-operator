using System;
using System.Collections.Generic;
using System.Linq;
using AdminService.Models;

namespace AdminService.Data {
    public class TripAppointmentRepo : ITripAppointmentRepo {
        private readonly AppDbContext _context;
        public TripAppointmentRepo(AppDbContext context) {
            _context = context;
        }

        public bool SaveChanges() {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<TripAppointment> GetAllTripAppointments() {
            return _context.TripAppointments.ToList();
        }

        public TripAppointment GetTripAppointmentById(int id) {
            return _context.TripAppointments.FirstOrDefault(s => s.Id == id);
        }

        public void CreateTripAppointment(TripAppointment tripAppointment) {
            if (tripAppointment == null)
                throw new ArgumentNullException();

            _context.TripAppointments.Add(tripAppointment);
        }
    }
}