﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Weather.openWeather
{
    class wather
    {
        public int id;

        public string main;

        public string description;

        public string icon;
        
        public Bitmap Icon
        {
            get 
            {
                return new Bitmap(Image.FromFile($"icons/{icon}.png"));
            }
        }
    }
}
