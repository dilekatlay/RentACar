using Business.Request.Fuel;
using Business.Responses.Fuel;

namespace Business.Abstract
{
    public interface IFuelService
    {
        public GetFuelListResponse GetList(GetFuelListRequest request);

        public GetFuelByIdResponse GetById(GetFuelByIdRequest request);

        public AddFuelResponse Add(AddFuelRequest request);

        public UpdateFuelResponse Update(UpdateFuelRequest request);

        public DeleteFuelResponse Delete(DeleteFuelRequest request);
    }
}