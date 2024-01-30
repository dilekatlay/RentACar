using Business;
using Business.Abstract;
using Business.Request.Fuel;
using Business.Request.Model;
using Business.Requests.Model;
using Business.Responses.Fuel;
using Business.Responses.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelController : ControllerBase
    {
        private readonly IFuelService _fuelService;

        public FuelController(IFuelService fuelService)
        {
            _fuelService = fuelService;
        }

        [HttpGet] // GET http://localhost:5245/api/models
        public GetFuelListResponse GetList([FromQuery] GetFuelListRequest request)
        {
            GetFuelListResponse response = _fuelService.GetList(request);
            return response;
        }

        [HttpGet("{Id}")] // GET http://localhost:5245/api/models/1
        public GetFuelByIdResponse GetById([FromRoute] GetFuelByIdRequest request)
        {
            GetFuelByIdResponse response = _fuelService.GetById(request);
            return response;
        }

        [HttpPost] // POST http://localhost:5245/api/models
        public ActionResult<AddFuelResponse> Add(AddFuelRequest request)
        {
            AddFuelResponse response = _fuelService.Add(request);
            return CreatedAtAction( // 201 Created
                actionName: nameof(GetById),
                routeValues: new { Id = response.Id }, // Anonymous object
                                                       // Response Header: Location=http://localhost:5245/api/models/1

                value: response // Response Body: JSON
            );
        }

        [HttpPut("{Id}")] // PUT http://localhost:5245/api/models/1
        public ActionResult<UpdateFuelResponse> Update(
            [FromRoute] int Id,
            [FromBody] UpdateFuelRequest request
        )
        {
            if (Id != request.Id)
                return BadRequest();

            UpdateFuelResponse response = _fuelService.Update(request);
            return Ok(response);
        }

        [HttpDelete("{Id}")] // DELETE http://localhost:5245/api/models/1
        public DeleteFuelResponse Delete([FromRoute] DeleteFuelRequest request)
        {
            DeleteFuelResponse response = _fuelService.Delete(request);
            return response;
        }
    }
}