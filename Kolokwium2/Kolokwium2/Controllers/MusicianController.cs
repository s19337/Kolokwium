using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2.Exceptions;
using Kolokwium2.Models;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers
{
    [Route("api/musicians")]
    [ApiController]
    public class MusicianController : ControllerBase
    {
        private readonly IMusicDbService _dbService;
        public MusicianController(IMusicDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetMusicians(int id)
        {
            try
            {
                return Ok(_dbService.GetMusician(id));
            }
            catch (MusicianDoesNotExistsException exc)
            {
                return NotFound(exc.Message);
            }
        }

        [HttpPost]
        public IActionResult AddMusician(Musician musician)
        {

            try
            {
                _dbService.addMusician(musician);
                return Ok();
            }
            catch (TrackDoesNotExistsException exc)
            {
                return NotFound(exc.Message);
            }
        }

    }
}