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
    [Route("api/stars")]
    public class StarController : ControllerBase
    {
        

        private readonly IRepo _repo;
        private readonly IMapper _map;

        public StarController(IRepo repo,IMapper map){
            _repo = repo;
            _map = map;
            
        }
        [HttpGet]
        public ActionResult GetAllStars(){
            return Ok(_map.Map<IEnumerable<StarReadDto>>(_repo.GetAllStars()));
        }
        [HttpGet("{id}", Name="GetStarById")]
        public ActionResult GetStarById(string id){
            
            return Ok(_map.Map<StarReadDto>(_repo.GetStarById(id)));
        }

        [HttpPost]
        public ActionResult AddStar(StarWriteDto s){
            var star = _map.Map<Star>(s);

            _repo.AddStar(star);
            _repo.SaveChanges();

            return CreatedAtRoute(nameof(GetStarById),new {Id = star.Id}, star);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateStar(string id, StarUpdateDto s){
            var existingStar = _repo.GetStarById(id);

            if(existingStar == null){
                return NotFound();
            }

            _map.Map(s, existingStar);

            _repo.UpdateStar(existingStar);

            _repo.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStar(string id){
            var existingStar = _repo.GetStarById(id);

            if(existingStar == null){
                return NotFound();
            }


            _repo.DeleteStar(existingStar);

            _repo.SaveChanges();

            return Ok();
        }
    }
}