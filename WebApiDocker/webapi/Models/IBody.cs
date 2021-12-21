using System;
using System.Collections.Generic;
using System.Text;

namespace webapi.Models
{
    interface IBody
    {
        string Name { get; set; }
        string Id { get; set; }
        string Description { get; set; }
        double MassComparedToEarth { get; set; }
        double MeanRadius { get; set; }
        double MeanTemperature { get; set; }
        BodyType BodyType { get; set; }

        string getInfo();

    }
}
