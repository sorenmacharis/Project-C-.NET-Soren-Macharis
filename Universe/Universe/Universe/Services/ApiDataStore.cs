using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Backend;
using Newtonsoft.Json;

namespace Universe.Services
{
    class ApiDataStore
    {
        public static List<Star> StarList = new List<Star>();
        public static List<Planet> PlanetList = new List<Planet>();
        public static List<Moon> MoonList = new List<Moon>();

        public async Task<List<Star>> GetAllStars()
        {
            HttpClient client = new HttpClient();
            String response = await client.GetStringAsync("http://10.0.2.2:8000/api/stars");

            return JsonConvert.DeserializeObject<List<Star>>(response);
        }

        public void AddStar(Star star)
        {
            StarList.Add(star);
        }

        public void DeleteStar(Star star)
        {
            StarList.Remove(star);
        }

        public async Task<List<Planet>> GetAllPlanets()
        {
            HttpClient client = new HttpClient();
            String response = await client.GetStringAsync("http://10.0.2.2:8000/api/planets");

            return JsonConvert.DeserializeObject<List<Planet>>(response);
        }

        public void AddPlanet(Planet planet)
        {
            PlanetList.Add(planet);
        }

        public void DeletePlanet(Planet planet)
        {
            PlanetList.Remove(planet);
        }

        public async Task<List<Moon>> GetAllMoons()
        {
            HttpClient client = new HttpClient();
            String response = await client.GetStringAsync("http://10.0.2.2:8000/api/moons");

            return JsonConvert.DeserializeObject<List<Moon>>(response);
        }

        public void AddMoon(Moon moon)
        {
            MoonList.Add(moon);
        }

        public void DeleteMoon(Moon moon)
        {
            MoonList.Remove(moon);
        }
    }
}
