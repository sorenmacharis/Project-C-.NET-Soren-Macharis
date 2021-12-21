
using System.Collections.Generic;
using webapi.Models;

namespace webapi.Repositories
{
    public interface IRepo
    {
         IEnumerable<Planet> GetAllPlanets();
         Planet GetPlanetById(string id);

         IEnumerable<Moon> GetAllMoons();
        Moon GetMoonById(string id);

        IEnumerable<Star> GetAllStars();
        Star GetStarById(string id);

        void AddPlanet(Planet p);

        void AddMoon(Moon m);

        void AddStar(Star s);

        void UpdatePlanet(Planet p);

        void UpdateMoon(Moon m);

        void UpdateStar(Star s);

        void DeletePlanet(Planet p);

        void DeleteMoon(Moon m);

        void DeleteStar(Star s);

        void SaveChanges();
         
    }
}