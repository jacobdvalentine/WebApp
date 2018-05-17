using AutoMapper;
using vega.Controllers.ContollerInterfaces;

namespace vega.Mapping
{
    // AutoMapper profile mapping class for mapping a types properties to another
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Map for mapping Make to IMake 
            CreateMap<Model.Make, IMake>();
            // Map for mapping Model to IModel 
            CreateMap<Model.Model, IModel>();
        }
    }
}