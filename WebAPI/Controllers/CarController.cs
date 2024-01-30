using Business;
using Business.Abstract;
using Business.Request.Car;
using Business.Request.Model;
using Business.Requests.Car;
using Business.Requests.Model;
using Business.Responses.Car;
using Business.Responses.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet] // GET http://localhost:5245/api/models
        public GetCarListResponse GetList([FromQuery] GetCarListRequest request)
        {
            GetCarListResponse response = _carService.GetList(request);
            return response;
        }

        [HttpGet("{Id}")] // GET http://localhost:5245/api/models/1
        public GetCarByIdResponse GetById([FromRoute] GetCarByIdRequest request)
        {
            GetCarByIdResponse response = _carService.GetById(request);
            return response;
        }

        [HttpPost] // POST http://localhost:5245/api/models
        public ActionResult<AddCarResponse> Add(AddCarRequest request)
        {
            AddCarResponse response = _carService.Add(request);
            return CreatedAtAction( // 201 Created
                actionName: nameof(GetById),
                routeValues: new { Id = response.Id }, // Anonymous object
                                                       // Response Header: Location=http://localhost:5245/api/models/1

                value: response // Response Body: JSON
            );
        }

        [HttpPut("{Id}")] // PUT http://localhost:5245/api/models/1
        public ActionResult<UpdateCarResponse> Update(
            [FromRoute] int Id,
            [FromBody] UpdateCarRequest request
        )
        {
            if (Id != request.Id)
                return BadRequest();

            UpdateCarResponse response = _carService.Update(request);
            return Ok(response);
        }

        [HttpDelete("{Id}")] // DELETE http://localhost:5245/api/models/1
        public DeleteCarResponse Delete([FromRoute] DeleteCarRequest request)
        {
            DeleteCarResponse response = _carService.Delete(request);
            return response;
        }
    }
}