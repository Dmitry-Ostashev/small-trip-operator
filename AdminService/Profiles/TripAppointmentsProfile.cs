using AdminService.Dtos;
using AdminService.Models;
using AutoMapper;

namespace AdminService.Profiles {
    public class TripAppointmentsProfile : Profile {
        public TripAppointmentsProfile() {
            CreateMap<TripAppointment, TripAppointmentReadDto>();
            CreateMap<TripAppointmentCreateDto, TripAppointment>();
        }
    }
}