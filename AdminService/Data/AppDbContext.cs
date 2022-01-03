using AdminService.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminService.Data {
    public class AppDbContext: DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}

        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<TripAppointment> TripAppointments { get; set; }
        public DbSet<TripDescription> TripDescriptions { get; set; }
    }
}