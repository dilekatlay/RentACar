using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class UsersBusinessRules
    {
        private readonly IUsersDal _usersDal;
        public UsersBusinessRules(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }


        public void CheckIfUsersExists(Users? users)
        {
            if (users is null)
                throw new NotFoundException("Users not found.");
        }
    }
}
