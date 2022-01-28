using System.Threading.Tasks;
using AdminService.Dtos;

namespace AdminService.SyncDataServices.Http {
    public interface ICommandDataClient {
        Task SendScheduleToCommand(ScheduleReadDto schedule);
    }
}