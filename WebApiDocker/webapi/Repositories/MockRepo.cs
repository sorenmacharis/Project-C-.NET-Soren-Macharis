using System.Collections.Generic;
using System.Linq;
using webapi.Models;

namespace webapi.Repositories
{
    public class MockRepo : IRepo
    {
       List<Planet> planetList = new List<Planet>();

        public MockRepo()
        {
            planetList.Add(new Planet("1","alpha","",1,1,1,false,false,"0"));
            planetList.Add(new Planet("1","alpha","",1,1,1,false,false,"0"));
            planetList.Add(new Planet("1","alpha","",1,1,1,false,false,"0"));
        }

        public void AddMoon(Moon m)
        {
            throw new System.NotImplementedException();
        }

        public void AddPlanet(Planet p)
        {
            throw new System.NotImplementedException();
        }

        public void AddStar(Star s)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteMoon(Moon m)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePlanet(Planet p)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteStar(Star s)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Moon> GetAllMoons()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Planet> GetAllPlanets(){
            return this.planetList;
        }

        public IEnumerable<Star> GetAllStars()
        {
            throw new System.NotImplementedException();
        }

        public Moon GetMoonById(string id)
        {
            throw new System.NotImplementedException();
        }

        public Planet GetPlanetById(string id){
            Planet _planet= planetList.FirstOrDefault<Planet>(p => p.Id == id);
            return _planet;
        }

        public Star GetStarById(string id)
        {
            throw new System.NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateMoon(Moon m)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePlanet(Planet p)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateStar(Star s)
        {
            throw new System.NotImplementedException();
        }
    }
}