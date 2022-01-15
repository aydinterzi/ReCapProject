using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm]IFormFile file, [FromForm] CarImage carImage)
        {
            _carImageService.Add(file, carImage);
            return Ok();
        }
        
        [HttpGet("getimagesbyid")]
        public IActionResult GetImagesByCarId(int id)
        {
           var result= _carImageService.GetByCarId(id);
            if(result.Success)
            return Ok(result);
            return BadRequest();
        }
    }
}
