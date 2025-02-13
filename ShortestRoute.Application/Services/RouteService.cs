using ShortestRoute.Domain.Entities;
using ShortestRoute.Domain.Interfaces;
using ShortestRoute.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestRoute.Application.Services
{
    public class RouteService : IRouteService
    {
        public Domain.Entities.Ruta GetShortestRoute(RouteRequestDTO request)
        {
            throw new NotImplementedException("To do: Algoritmo para ruta mas corta");
        }
    }
}
