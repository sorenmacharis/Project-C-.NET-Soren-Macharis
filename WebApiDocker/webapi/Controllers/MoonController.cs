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
    [Route("api/moons")]
    public class MoonController : ControllerBase
    {
        

        private readonly IRepo _repo;
        private readonly IMapper _map;

        public MoonController(IRepo repo,IMapper map){
            _repo = repo;
            _map = map;
            
        }
        [HttpGet]
        public ActionResult GetAllMoons(){
            return Ok(_map.Map<IEnumerable<MoonReadDto>>(_repo.GetAllMoons()));
        }
        [HttpGet("{id}", Name="GetMoonById")]
        public ActionResult GetMoonById(string id){
            
            return Ok(_map.Map<MoonReadDto>(_repo.GetMoonById(id)));
        }

        [HttpPost]
        public ActionResult AddMoon(MoonWriteDto m){
            var moon = _map.Map<Moon>(m);

            _repo.AddMoon(moon);
            _repo.SaveChanges();

            return CreatedAtRoute(nameof(GetMoonById),new {Id = moon.Id}, moon);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateMoon(string id, MoonUpdateDto m){
            var existingMoon = _repo.GetMoonById(id);

            if(existingMoon == null){
                return NotFound();
            }

            _map.Map(m, existingMoon);

            _repo.UpdateMoon(existingMoon);

            _repo.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMoon(string id){
            var existingMoon = _repo.GetMoonById(id);

            if(existingMoon == null){
                return NotFound();
            }


            _repo.DeleteMoon(existingMoon);

            _repo.SaveChanges();

            return Ok();
        }
    }
}
