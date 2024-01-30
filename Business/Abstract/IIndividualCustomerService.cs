using Business.Request.Model;
using Business.Requests.Model;
using Business.Responses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIndividualCustomerService
    {
        public GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request);

        public GetIndividualCustomerByIdResponse GetById(GetIndividualCustomerByIdRequest request);

        public AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request);

        public UpdateIndividualCustomerResponse Update(UpdateIndividualCustomerRequest request);

        public DeleteIndividualCustomerResponse Delete(DeleteIndividualCustomerRequest request);
    }
}
