using Business;
using Business.Abstract;
using Business.Concrete;
using Business.Request.Brand;
using Business.Request.Model;
using Business.Requests.Model;
using Business.Responses.Brand;
using Business.Responses.Model;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController : ControllerBase
{
    private readonly IBrandService _brandService;

    public BrandsController(IBrandService brandService)
    {
        _brandService = brandService;
    }

    [HttpGet] // GET http://localhost:5245/api/models
    public GetBrandListResponse GetList([FromQuery] GetBrandListRequest request)
    {
        GetBrandListResponse response = _brandService.GetList(request);
        return response;
    }

    [HttpGet("{Id}")] // GET http://localhost:5245/api/models/1
    public GetBrandByIdResponse GetById([FromRoute] GetBrandByIdRequest request)
    {
        GetBrandByIdResponse response = _brandService.GetById(request);
        return response;
    }

    [HttpPost] // POST http://localhost:5245/api/models
    public ActionResult<AddBrandResponse> Add(AddBrandRequest request)
    {
        AddBrandResponse response = _brandService.Add(request);
        return CreatedAtAction( // 201 Created
            actionName: nameof(GetById),
            routeValues: new { Id = response.Id }, // Anonymous object
                                                   // Response Header: Location=http://localhost:5245/api/models/1

            value: response // Response Body: JSON
        );
    }

    [HttpPut("{Id}")] // PUT http://localhost:5245/api/models/1
    public ActionResult<UpdateBrandResponse> Update(
        [FromRoute] int Id,
        [FromBody] UpdateBrandRequest request
    )
    {
        if (Id != request.Id)
            return BadRequest();

        UpdateBrandResponse response = _brandService.Update(request);
        return Ok(response);
    }

    [HttpDelete("{Id}")] // DELETE http://localhost:5245/api/models/1
    public DeleteBrandResponse Delete([FromRoute] DeleteBrandRequest request)
    {
        DeleteBrandResponse response = _brandService.Delete(request);
        return response;
    }
}