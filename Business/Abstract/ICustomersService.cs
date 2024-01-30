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
    public interface ICustomersService
    {
        public GetCustomersListResponse GetList(GetCustomersListRequest request);

        public GetCustomersByIdResponse GetById(GetCustomersByIdRequest request);

        public AddCustomersResponse Add(AddCustomersRequest request);

        public UpdateCustomersResponse Update(UpdateCustomersRequest request);

        public DeleteCustomersResponse Delete(DeleteCustomersRequest request);
    }
}
