using AutoMapper;
using FinalProjectPRN231.API.DTO.EmployeerDTO;
using FinalProjectPRN231.CoreBusiness.Entities;

namespace FinalProjectPRN231.API
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            CreateMap<EmployeerDTO, Employeer>();
            CreateMap<Employeer, EmployeerDTO>();
        }
    }
}
