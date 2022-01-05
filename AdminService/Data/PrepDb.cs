using System;
using System.Linq;
using AdminService.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AdminService.Data {
    public static class PrepDb {
        private static void SeedData (AppDbContext context) {
            if (!context.TripDescriptions.Any()) {
                Console.WriteLine("Seeding data...");

                context.TripDescriptions.Add(new TripDescription() { Title = "Moscow Journey" });
                context.Schedules.Add(new Schedule() { Title = "Tula", City = "Tula" });

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