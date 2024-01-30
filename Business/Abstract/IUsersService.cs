using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUsersService
    {
        public GetUsersListResponse GetList(GetUsersListRequest request);

        public GetUsersByIdResponse GetById(GetUsersByIdRequest request);

        public AddUsersResponse Add(AddUsersRequest request);

        public UpdateUsersResponse Update(UpdateUsersRequest request);

        public DeleteUsersResponse Delete(DeleteUsersRequest request);
    }
}
