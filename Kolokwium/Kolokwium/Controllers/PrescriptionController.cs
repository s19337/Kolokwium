using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.DTOs.Requests;
using Kolokwium.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers
{
    [Route("api/prescription")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {

        private IDbService _dbService;

        public PrescriptionController(IDbService dbService)
        {
            _dbService = dbService;
        }


        [HttpGet]
        public IActionResult GetPrescription(String lastName)
        {
            var list = _dbService.GetPrescription(lastName);
            if (list != null)
                return Ok(list);
            else return BadRequest();
        }


        public IActionResult AddMedicament(MedicamentRequest request)
        {
            var pr = _dbService.AddMedicament( request);
            if (pr != null)
                return Ok();
            else return BadRequest();
        }

    }

}