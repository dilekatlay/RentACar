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
    public class CorporateCustomersController : ControllerBase
    {
        private readonly ICorporateCustomerService _corporateCustomerService;

        public CorporateCustomersController(ICorporateCustomerService corporateCustomerService)
        {
            _corporateCustomerService = corporateCustomerService;
        }

        [HttpGet] // GET http://localhost:5245/api/models
        public GetCorporateCustomerListResponse GetList([FromQuery] GetCorporateCustomerListRequest request)
        {
            GetCorporateCustomerListResponse response = _corporateCustomerService.GetList(request);
            return response;
        }

        [HttpGet("{Id}")] // GET http://localhost:5245/api/models/1
        public GetCorporateCustomerByIdResponse GetById([FromRoute] GetCorporateCustomerByIdRequest request)
        {
            GetCorporateCustomerByIdResponse response = _corporateCustomerService.GetById(request);
            return response;
        }

        [HttpPost] // POST http://localhost:5245/api/models
        public ActionResult<AddCorporateCustomerResponse> Add(AddCorporateCustomerRequest request)
        {
            AddCorporateCustomerResponse response = _corporateCustomerService.Add(request);
            return CreatedAtAction( // 201 Created
                actionName: nameof(GetById),
                routeValues: new { Id = response.Id }, // Anonymous object
                                                       // Response Header: Location=http://localhost:5245/api/models/1

                value: response // Response Body: JSON
            );
        }

        [HttpPut("{Id}")] // PUT http://localhost:5245/api/models/1
        public ActionResult<UpdateCorporateCustomerResponse> Update(
            [FromRoute] int Id,
            [FromBody] UpdateCorporateCustomerRequest request
        )
        {
            if (Id != request.Id)
                return BadRequest();

            UpdateCorporateCustomerResponse response = _corporateCustomerService.Update(request);
            return Ok(response);
        }

        [HttpDelete("{Id}")] // DELETE http://localhost:5245/api/models/1
        public DeleteCorporateCustomerResponse Delete([FromRoute] DeleteCorporateCustomerRequest request)
        {
            DeleteCorporateCustomerResponse response = _corporateCustomerService.Delete(request);
            return response;
        }
    }
}