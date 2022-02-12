﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement.Services.Entities
{
    public class Borne
    {
        public int Id { get; set; }
        public Intersection Intersection { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
    }
}
