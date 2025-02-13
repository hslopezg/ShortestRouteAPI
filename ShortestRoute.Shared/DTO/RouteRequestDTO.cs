using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestRoute.Shared.DTO
{
    public class RouteRequestDTO
    {
        public List<string> Cities { get; set; }
        public List<RoadDto> Roads { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
    }

    public class RoadDto
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Time { get; set; }
    }

}
