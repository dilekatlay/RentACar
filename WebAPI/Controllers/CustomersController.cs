using Business;
using Business.Abstract;
using Business.Request.Model;
using Business.Requests.Model;
using Business.Responses.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _customersService;

        public CustomersController(ICustomersService customersService)
        {
            _customersService = customersService;
        }

        [HttpGet] // GET http://localhost:5245/api/models
        public GetCustomersListResponse GetList([FromQuery] GetCustomersListRequest request)
        {
            GetCustomersListResponse response = _customersService.GetList(request);
            return response;
        }

        [HttpGet("{Id}")] // GET http://localhost:5245/api/models/1
        public GetCustomersByIdResponse GetById([FromRoute] GetCustomersByIdRequest request)
        {
            GetCustomersByIdResponse response = _customersService.GetById(request);
            return response;
        }

        [HttpPost] // POST http://localhost:5245/api/models
        public ActionResult<AddCustomersResponse> Add(AddCustomersRequest request)
        {
            AddCustomersResponse response = _customersService.Add(request);
            return CreatedAtAction( // 201 Created
                actionName: nameof(GetById),
                routeValues: new { Id = response.Id }, // Anonymous object
                                                       // Response Header: Location=http://localhost:5245/api/models/1

                value: response // Response Body: JSON
            );
        }

        [HttpPut("{Id}")] // PUT http://localhost:5245/api/models/1
        public ActionResult<UpdateCustomersResponse> Update(
            [FromRoute] int Id,
            [FromBody] UpdateCustomersRequest request
        )
        {
            if (Id != request.Id)
                return BadRequest();

            UpdateCustomersResponse response = _customersService.Update(request);
            return Ok(response);
        }

        [HttpDelete("{Id}")] // DELETE http://localhost:5245/api/models/1
        public DeleteCustomersResponse Delete([FromRoute] DeleteCustomersRequest request)
        {
            DeleteCustomersResponse response = _customersService.Delete(request);
            return response;
        }

    }
}