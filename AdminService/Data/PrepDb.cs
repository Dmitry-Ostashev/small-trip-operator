using System;
using System.Collections.Generic;
using System.Linq;
using AdminService.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AdminService.Data {
    public static class PrepDb {
        private static void SeedData (AppDbContext context) {
            if (!context.TripDescriptions.Any()) {
                Console.WriteLine("Seeding data...");

                var tripDescription = new TripDescription() { Title = "Moscow Journey" };
                var tripAppointment = new TripAppointment() { Date = new DateTime(), TripDescription = tripDescription };
                var schedule = new Schedule() { Title = "Tula", City = "Tula", Appointments = new List<TripAppointment>() { tripAppointment } };

                context.TripDescriptions.Add(tripDescription);
                context.TripAppointments.Add(tripAppointment);
                context.Schedules.Add(schedule);

                context.SaveChanges();
            }            
        }
        public static void PreparePopulation (IApplicationBuilder app) {
            using (var serviceScope = app.ApplicationServices.CreateScope()) {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }
    }
}