using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.dto;
using webapi.Models;
using webapi.Repositories;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/planets")]
    public class PlanetController : ControllerBase
    {
        

        private readonly IRepo _repo;
        private readonly IMapper _map;

        public PlanetController(IRepo repo,IMapper map){
            _repo = repo;
            _map = map;
            
        }
        [HttpGet]
        public ActionResult GetAllPlanets(){
            return Ok(_map.Map<IEnumerable<PlanetReadDto>>(_repo.GetAllPlanets()));
        }
        [HttpGet("{id}", Name="GetPlanetById")]
        public ActionResult GetPlanetById(string id){
            
            return Ok(_map.Map<PlanetReadDto>(_repo.GetPlanetById(id)));
        }

        [HttpPost]
        public ActionResult AddPlanet(PlanetWriteDto p){
            var planet = _map.Map<Planet>(p);

            _repo.AddPlanet(planet);
            _repo.SaveChanges();

            return CreatedAtRoute(nameof(GetPlanetById),new {Id = planet.Id}, planet);
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePlanet(string id, PlanetUpdateDto p){
            var existingPlanet = _repo.GetPlanetById(id);

            if(existingPlanet == null){
                return NotFound();
            }

            _map.Map(p, existingPlanet);

            _repo.UpdatePlanet(existingPlanet);

            _repo.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePlanet(string id){
            var existingPlanet = _repo.GetPlanetById(id);

            if(existingPlanet == null){
                return NotFound();
            }


            _repo.DeletePlanet(existingPlanet);

            _repo.SaveChanges();

            return Ok();
        }
    }
}