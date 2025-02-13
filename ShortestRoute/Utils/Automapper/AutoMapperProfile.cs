using AutoMapper;
using ShortestRoute.Domain.Entities;
using ShortestRoute.Shared.DTO;

namespace ShortestRoute.Utils.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region RouteResponse
            CreateMap<Ruta, RouteResponseDTO>()
                .ForMember(destino => destino.Route,
                           opt => opt.MapFrom(origen => origen.Cities)
                 )
                .ForMember(destino => destino.Time,
                           opt => opt.MapFrom(origen => origen.Time)
                );
            #endregion
        }
    }
}
