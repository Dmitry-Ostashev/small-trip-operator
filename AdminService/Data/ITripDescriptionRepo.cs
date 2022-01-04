using System.Collections.Generic;
using AdminService.Models;

namespace AdminService.Data {
    public interface ITripDescriptionRepo {
        bool SaveChanges();

        IEnumerable<TripDescription> GetAllTripDescriptions();

        TripDescription GetTripDescriptionById(int id);

        void CreateTripDescription(TripDescription tripDescription);
    }
}