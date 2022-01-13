using AdminService.Dtos;
using AdminService.Models;
using AutoMapper;

namespace AdminService.Profiles {
    public class TripDescriptionsProfile : Profile {
        public TripDescriptionsProfile() {
            CreateMap<TripDescription, TripDescriptionReadDto>();
            CreateMap<TripDescriptionCreateDto, TripDescription>();
        }
    }
}