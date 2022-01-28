using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AdminService.Dtos;
using Microsoft.Extensions.Configuration;

namespace AdminService.SyncDataServices.Http {
    public class HttpCommandDataClient : ICommandDataClient {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public HttpCommandDataClient(HttpClient httpClient, IConfiguration configuration) {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task SendScheduleToCommand(ScheduleReadDto schedule) {
            var httpContent = new StringContent(
                JsonSerializer.Serialize(schedule),
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpClient.PostAsync($"{_configuration["CommandService"]}", httpContent);

            if (response.IsSuccessStatusCode)
                Console.WriteLine("--> Sync Post to AdminService was OK");
            else
                Console.WriteLine("--> Sync Post to AdminService was failed");
        }
    }
}
