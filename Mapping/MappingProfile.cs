using AutoMapper;
using vega.Controllers.ContollerInterfaces;
using vega.Models;

namespace vega.Mapping
{
    // AutoMapper profile mapping class for mapping a types properties to another
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Map for mapping Make to IMake 
            CreateMap<Make, IMake>();
            // Map for mapping Model to IModel 
            CreateMap<Models.Model, IModel>();
            // Map for mapping Features to IFeaturs
            CreateMap<Models.Feature, IFeature>();
        }
    }
}