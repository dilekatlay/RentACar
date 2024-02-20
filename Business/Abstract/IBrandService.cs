using Business.Request.Brand;
using Business.Responses.Brand;
using Entities.Concrete;

namespace Business.Abstract;

public interface IBrandService
{
    public GetBrandListResponse GetList(GetBrandListRequest request);

    Brand? GetById(int id); // ToDo: Replace with DTO.
    public GetBrandByIdResponse GetById(GetBrandByIdRequest request);

    public AddBrandResponse Add(AddBrandRequest request);

    public UpdateBrandResponse Update(UpdateBrandRequest request);
     
    public DeleteBrandResponse Delete(DeleteBrandRequest request);
}