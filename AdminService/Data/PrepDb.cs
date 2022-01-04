using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AdminService.Data {
    public static class PrepDb {
        private static void SeedData (AppDbContext context) {
            
        }
        public static void PreparePopulation (IApplicationBuilder app) {
            using (var serviceScope = app.ApplicationServices.CreateScope()) {

            }
        }
    }
}