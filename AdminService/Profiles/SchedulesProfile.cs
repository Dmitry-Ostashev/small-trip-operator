using AdminService.Dtos;
using AdminService.Models;
using AutoMapper;

namespace AdminService.Profiles {
    public class SchedulesProfile : Profile {
        public SchedulesProfile() {
            CreateMap<Schedule, ScheduleReadDto>();
            CreateMap<ScheduleCreateDto, Schedule>();
        }
    }
}