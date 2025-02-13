using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShortestRoute.Domain.Interfaces;
using ShortestRoute.Shared.DTO;

namespace ShortestRoute.Controllers
{
    [ApiController]
    [Route("route")]
    public class RouteController : ControllerBase
    {

        private readonly IRouteService _routeService;
        private readonly IMapper _mapper;

        public RouteController(IRouteService routeService, IMapper mapper)
        {
            _routeService = routeService;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult ShortestRoute([FromBody] RouteRequestDTO request)
        {
            if (request.Cities.Count == 0 || request.Roads.Count == 0) 
            {
                return BadRequest("Please provide cities and roads");
            }

            RouteResponseDTO route = _mapper.Map<RouteResponseDTO>(_routeService.GetShortestRoute(request));

            return Ok(route);

        }

    }
}
