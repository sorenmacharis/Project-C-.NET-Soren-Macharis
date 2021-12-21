using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    public class Moon : IBody
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public double MassComparedToEarth { get; set; }
        public double MeanRadius { get; set; }
        public double MeanTemperature { get; set; }
        public bool Atmosphere { get; set; }
        public bool ComplexLife { get; set; }
        public BodyType BodyType { get; set; }
        public string ParentPlanetId { get; set; }

        public Moon(string id, string name, string description, double massComparedToEarth, double meanRadius, double MeanTemperature, bool complexLife, bool atmosphere, string parentId)
        {
            this.Name = name;
            this.Id = id;
            this.Description = description;
            this.MassComparedToEarth = massComparedToEarth;
            this.MeanRadius = meanRadius;
            this.MeanTemperature = MeanTemperature;
            this.Atmosphere = atmosphere;
            this.ComplexLife = complexLife;
            this.BodyType = BodyType.MOON;
            this.ParentPlanetId = parentId;
        }

        public string getInfo()
        {
            string tmp = "";
            tmp = Id + " " + Name + " " + Description + " Child of: " + ParentPlanetId;
            return tmp;
        }
    }
}
