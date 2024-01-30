using Business;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualCustomersController : ControllerBase
    {
        private readonly IIndividualCustomerService _individualCustomerService;

        public IndividualCustomersController(IIndividualCustomerService individualCustomerService)
        {
            _individualCustomerService = individualCustomerService;
        }
        [HttpGet]
        public GetIndividualCustomerListResponse GetList([FromQuery] GetIndividualCustomerListRequest request)
        {
            GetIndividualCustomerListResponse response = _individualCustomerService.GetList(request);
            return response;
        }
        [HttpGet("{Id}")]
        public GetIndividualCustomerByIdResponse GetById([FromRoute] GetIndividualCustomerByIdRequest request)
        {
            GetIndividualCustomerByIdResponse response = _individualCustomerService.GetById(request);
            return response;
        }
        [HttpPost]
        public ActionResult<AddIndividualCustomerResponse> Add(AddIndividualCustomerRequest request)
        {
            AddIndividualCustomerResponse response = _individualCustomerService.Add(request);
            return CreatedAtAction(actionName: nameof(GetById), routeValues: new { response.Id }, value: response);
        }
        [HttpPut("{Id}")]
        public ActionResult<UpdateIndividualCustomerResponse> Update([FromRoute] int Id, [FromBody] UpdateIndividualCustomerRequest request)
        {
            if (Id != request.Id)
                return BadRequest();
            UpdateIndividualCustomerResponse response = _individualCustomerService.Update(request);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public DeleteIndividualCustomerResponse Delete([FromRoute] DeleteIndividualCustomerRequest request)
        {
            DeleteIndividualCustomerResponse response = _individualCustomerService.Delete(request);
            return response;
        }

    }
}