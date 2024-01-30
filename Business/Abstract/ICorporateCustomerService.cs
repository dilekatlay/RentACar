using Business.Request.Brand;
using Business.Request.Model;
using Business.Requests.Model;
using Business.Responses.Brand;
using Business.Responses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICorporateCustomerService
    {
        public GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request);

        public GetCorporateCustomerByIdResponse GetById(GetCorporateCustomerByIdRequest request);

        public AddCorporateCustomerResponse Add(AddCorporateCustomerRequest request);

        public UpdateCorporateCustomerResponse Update(UpdateCorporateCustomerRequest request);

        public DeleteCorporateCustomerResponse Delete(DeleteCorporateCustomerRequest request);
    }
}
