using System;
using System.Collections.Generic;
using System.Linq;
using AdminService.Models;

namespace AdminService.Data {
    public class TripDescriptionRepo : ITripDescriptionRepo {
        private readonly AppDbContext _context;
        public TripDescriptionRepo(AppDbContext context) {
            _context = context;
        }

        public bool SaveChanges() {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<TripDescription> GetAllTripDescriptions() {
            return _context.TripDescriptions.ToList();
        }

        public TripDescription GetTripDescriptionById(int id) {
            return _context.TripDescriptions.FirstOrDefault(s => s.Id == id);
        }

        public void CreateTripDescription(TripDescription tripDescription) {
            if (tripDescription == null)
                throw new ArgumentNullException();

            _context.TripDescriptions.Add(tripDescription);
        }
    }
}