﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestRoute.Domain.Entities
{
    public class Road
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Time { get; set; }
    }
}
