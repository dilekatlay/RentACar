using Business.Request.Model;
using Business.Request.Transmission;

using Business.Responses.Transmission;

namespace Business.Abstract
{
    public interface ITransmissionService
    {
        public GetTransmissionListResponse GetList(GetTransmissionListRequest request);

        public GetTransmissionByIdResponse GetById(GetTransmissionByIdRequest request);

        public AddTransmissionResponse Add(AddTransmissionRequest request);

        public UpdateTransmissionResponse Update(UpdateTransmissionRequest request);

        public DeleteTransmissionResponse Delete(DeleteTransmissionRequest request);

    }
}