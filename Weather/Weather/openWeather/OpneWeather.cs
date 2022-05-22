using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Weather.openWeather
{
     class OpneWeather
    {
        public Coord coodr;

        public wather[] weather;

        //используем атрибут который дает сборка джисон
        [JsonProperty("base")]

        public string Base;

        public Main main;

        public double visible;

        public wind wind;

        public clouds cloud;

        public double dt;

        public sys sy;

        public int id ;

        public string name;

        public double cod;
    }
}
