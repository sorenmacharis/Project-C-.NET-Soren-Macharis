using webapi.Models;

namespace webapi.dto
{
    public class StarUpdateDto
    {
        
        public string Name { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public double MassComparedToEarth { get; set; }
        public double MeanRadius { get; set; }
        public double MeanTemperature { get; set; }
        public BodyType BodyType { get; set; }
        public StarType StarType { get; set; }
    }
}