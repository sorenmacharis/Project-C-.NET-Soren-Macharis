using webapi.Models;

namespace webapi.dto
{
    public class PlanetWriteDto
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
    }
}