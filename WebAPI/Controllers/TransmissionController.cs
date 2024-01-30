using Business;
using Business.Abstract;
using Business.Request.Model;
using Business.Request.Transmission;
using Business.Requests.Model;
using Business.Responses.Model;
using Business.Responses.Transmission;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionController : ControllerBase
    {
        private readonly ITransmissionService _transmissionService;

        public TransmissionController(ITransmissionService transmissionService)
        {
            _transmissionService = transmissionService;
        }

        [HttpGet] // GET http://localhost:5245/api/models
        public GetTransmissionListResponse GetList([FromQuery] GetTransmissionListRequest request)
        {
            GetTransmissionListResponse response = _transmissionService.GetList(request);
            return response;
        }

        [HttpGet("{Id}")] // GET http://localhost:5245/api/models/1
        public GetTransmissionByIdResponse GetById([FromRoute] GetTransmissionByIdRequest request)
        {
            GetTransmissionByIdResponse response = _transmissionService.GetById(request);
            return response;
        }

        [HttpPost] // POST http://localhost:5245/api/models
        public ActionResult<AddTransmissionResponse> Add(AddTransmissionRequest request)
        {
            AddTransmissionResponse response = _transmissionService.Add(request);
            return CreatedAtAction( // 201 Created
                actionName: nameof(GetById),
                routeValues: new { Id = response.Id }, // Anonymous object
                                                       // Response Header: Location=http://localhost:5245/api/models/1

                value: response // Response Body: JSON
            );
        }

        [HttpPut("{Id}")] // PUT http://localhost:5245/api/models/1
        public ActionResult<UpdateTransmissionResponse> Update(
            [FromRoute] int Id,
            [FromBody] UpdateTransmissionRequest request
        )
        {
            if (Id != request.Id)
                return BadRequest();

            UpdateTransmissionResponse response = _transmissionService.Update(request);
            return Ok(response);
        }

        [HttpDelete("{Id}")] // DELETE http://localhost:5245/api/models/1
        public DeleteTransmissionResponse Delete([FromRoute] DeleteTransmissionRequest request)
        {
            DeleteTransmissionResponse response = _transmissionService.Delete(request);
            return response;
        }
    }
}