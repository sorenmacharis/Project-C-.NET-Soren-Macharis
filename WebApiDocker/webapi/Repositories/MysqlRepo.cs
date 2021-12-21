using System.Collections.Generic;
using System.Linq;
using webapi.Contexts;
using webapi.Models;

namespace webapi.Repositories
{
    public class MysqlRepo : IRepo
    {
        private readonly BodyContext _context;

        public MysqlRepo(BodyContext context)
        {
            _context = context;
        }

        public void AddMoon(Moon m)
        {
            _context.Moons.Add(m);
        }

        public void AddPlanet(Planet p)
        {
            _context.Planets.Add(p);
        }

        public void AddStar(Star s)
        {
            _context.Stars.Add(s);
        }

        public void DeleteMoon(Moon m)
        {
            _context.Moons.Remove(m);
        }

        public void DeletePlanet(Planet p)
        {
            _context.Planets.Remove(p);
        }

        public void DeleteStar(Star s)
        {
            _context.Stars.Remove(s);
        }

        public IEnumerable<Moon> GetAllMoons()
        {
            return _context.Moons;
        }

        public IEnumerable<Planet> GetAllPlanets()
        {
            return _context.Planets;
        }

        public IEnumerable<Star> GetAllStars()
        {
            return _context.Stars;
        }

        public Moon GetMoonById(string id)
        {
            return _context.Moons.FirstOrDefault<Moon>(p => p.Id == id);
        }

        public Planet GetPlanetById(string id)
        {
            return _context.Planets.FirstOrDefault<Planet>(p => p.Id == id);
        }

        public Star GetStarById(string id)
        {
            return _context.Stars.FirstOrDefault<Star>(p => p.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void UpdateMoon(Moon m)
        {
            
        }

        public void UpdatePlanet(Planet p)
        {
            
        }

        public void UpdateStar(Star s)
        {
            
        }
    }
}