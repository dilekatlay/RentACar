using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.FluentValidation.Users;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UsersManager : IUsersService
    {
        private readonly IUsersDal _usersDal;
        private readonly UsersBusinessRules _usersBusinessRules;
        private IMapper _mapper;
        public UsersManager(IUsersDal usersDal, UsersBusinessRules usersBusinessRules, IMapper mapper)
        {
            _usersDal = usersDal;
            _usersBusinessRules = usersBusinessRules;
            _mapper = mapper;
        }

        public AddUsersResponse Add(AddUsersRequest request)
        {
            ValidationTool.Validate(new AddUsersRequestValidator(), request);
            Users usersToAdd = _mapper.Map<Users>(request);
            _usersDal.Add(usersToAdd);
            AddUsersResponse response = _mapper.Map<AddUsersResponse>(usersToAdd);
            return response;
        }

        public DeleteUsersResponse Delete(DeleteUsersRequest request)
        {
            Users? usersToDelete = _usersDal.Get(predicate: users => users.Id == request.Id);
            _usersBusinessRules.CheckIfUsersExists(usersToDelete);
            Users deletedUsers = _usersDal.Delete(usersToDelete!);
            DeleteUsersResponse response = _mapper.Map<DeleteUsersResponse>(deletedUsers);
            return response;
        }

        public GetUsersByIdResponse GetById(GetUsersByIdRequest request)
        {
            Users? users = _usersDal.Get(predicate: users => users.Id == request.Id);
            GetUsersByIdResponse response = _mapper.Map<GetUsersByIdResponse>(users);
            return response;
        }

        public GetUsersListResponse GetList(GetUsersListRequest request)
        {
            IList<Users> usersList = _usersDal.GetList();
            GetUsersListResponse response = _mapper.Map<GetUsersListResponse>(usersList);
            return response;
        }

        public UpdateUsersResponse Update(UpdateUsersRequest request)
        {
            Users? usersToUpdate = _usersDal.Get(predicate: users => users.Id == request.Id);
            _usersBusinessRules.CheckIfUsersExists(usersToUpdate);
            usersToUpdate = _mapper.Map(request, usersToUpdate);
            Users updatedUsers = _usersDal.Update(usersToUpdate!);
            var response = _mapper.Map<UpdateUsersResponse>(updatedUsers);
            return response;
        }
    }
}
