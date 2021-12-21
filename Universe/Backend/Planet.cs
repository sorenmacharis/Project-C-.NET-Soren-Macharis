using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    public class Planet : IBody
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
        public string ParentStarId { get; set; }
        

        public Planet(string id, string name, string description, double massComparedToEarth, double meanRadius, double MeanTemperature, bool complexLife, bool atmosphere, string parentId)
        {
            this.Name = name;
            this.Id = id;
            this.Description = description;
            this.MassComparedToEarth = massComparedToEarth;
            this.MeanRadius = meanRadius;
            this.MeanTemperature = MeanTemperature;
            this.Atmosphere = atmosphere;
            this.ComplexLife = complexLife;
            this.BodyType = BodyType.PLANET;
            this.ParentStarId = parentId;
            
        }

        public string getInfo()
        {
            string tmp = "";
            tmp = Id + " " + Name + " " + Description + " Atmosphere present: " + Atmosphere;
            return tmp;

        }
    }
}
