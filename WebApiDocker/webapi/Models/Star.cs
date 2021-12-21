using System;
using System.Collections.Generic;
using System.Text;

namespace webapi.Models
{
    public class Star : IBody
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public double MassComparedToEarth { get; set; }
        public double MeanRadius { get; set; }
        public double MeanTemperature { get; set; }
        public BodyType BodyType { get; set; }
        public StarType StarType { get; set; }
      

        public Star(string id, string name, string description, double massComparedToEarth, double meanRadius, double MeanTemperature, StarType starType)
        {
            this.Name = name;
            this.Id = id;
            this.Description = description;
            this.MassComparedToEarth = massComparedToEarth;
            this.MeanRadius = meanRadius;
            this.MeanTemperature = MeanTemperature;
            this.StarType = starType;
            this.BodyType = BodyType.STAR;
            
        }

        public string getInfo()
        {
            string tmp = "";
            tmp = Id + " " + Name + " " + Description + " StarType: " + StarType;
            return tmp;
        }
    }
}
