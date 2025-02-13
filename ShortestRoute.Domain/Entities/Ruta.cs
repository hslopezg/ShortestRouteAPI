using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestRoute.Domain.Entities
{
    public class Ruta
    {
        public List<String> Cities { get; set; }

        public int Time { get; set; }
    }
}
