using ShortestRoute.Domain.Entities;
using ShortestRoute.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestRoute.Domain.Interfaces
{
    public interface IRouteService
    {
        public Ruta GetShortestRoute(RouteRequestDTO request);
    }
}
