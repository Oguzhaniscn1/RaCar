using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() 
        {
            var result = _rentalService.GetAllRentals();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("getbyid")]
        public IActionResult GetById(int id)
        {
            var resul=_rentalService.GetRantalById(id);
            if(resul.Success)
            {
                return Ok(resul);
            }
            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result=_rentalService.AddRental(rental);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        
        }

        [HttpPost("delete")]
        public IActionResult Delete(Rental rental)
        {
            var result=_rentalService.DeleteRental(rental);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(Rental renral)
        {
            var result = _rentalService.UpdateRental(renral);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }



    }
}
