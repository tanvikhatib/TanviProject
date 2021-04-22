﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.Models
{
    public class WeatherClass
    {
        public int id { get; set; }
        public string weather_state_name { get; set; }
        public string weather_state_abbr { get; set; }
        public string wind_direction_compass { get; set; }
        public DateTime created { get; set; }
        public DateTime applicable_date { get; set; }
        public float min_temp { get; set; }
        public float max_temp { get; set; }
        public float the_temp { get; set; }
        public float wind_speed { get; set; }
        public float wind_direction { get; set; }
        public float air_pressure { get; set; }
        public float humidity { get; set; }
        public float visibility { get; set; }
        public float predicability { get; set; }
    }



}
