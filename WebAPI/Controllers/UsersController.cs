using Business;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }
        [HttpGet] //GET http://localhost:5245/api/users
        public GetUsersListResponse GetList([FromQuery] GetUsersListRequest request)
        {
            GetUsersListResponse response = _usersService.GetList(request);
            return response;
        }
        [HttpGet("{Id}")]
        //GET http://localhost:5245/api/users/1
        public GetUsersByIdResponse GetById([FromRoute] GetUsersByIdRequest request)
        {
            GetUsersByIdResponse response = _usersService.GetById(request);
            return response;
        }
        [HttpPost] //POST http://localhost:5245/api/users
        public ActionResult<AddUsersResponse> Add(AddUsersRequest request)
        {
            AddUsersResponse response = _usersService.Add(request);
            return CreatedAtAction(//201 Created
                actionName: nameof(GetById), routeValues: new { Id = response.Id }, value: response);
        }
        [HttpPut("{Id}")] //PUT http://localhost:5245/api/users/1
        public ActionResult<UpdateUsersResponse> Update([FromRoute] int Id, [FromBody] UpdateUsersRequest request)
        {
            if (Id != request.Id)
                return BadRequest();
            UpdateUsersResponse response = _usersService.Update(request);
            return Ok(response);
        }
        [HttpDelete("{Id}")] //DELETE http://localhost:5245/api/user/1
        public DeleteUsersResponse Delete([FromRoute] DeleteUsersRequest request)
        {
            DeleteUsersResponse response = _usersService.Delete(request);
            return response;
        }
    }
}