using AutoMapper;
using Business.Dtos.IndividualCustomer;
using Business.Dtos.Users;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class UsersMapperProfiles : Profile
    {
        public UsersMapperProfiles()
        {
            CreateMap<AddUsersRequest, Users>();
            CreateMap<Users, AddUsersResponse>();

            CreateMap<Users, UsersListItemDto>();
            CreateMap<IList<Users>, GetUsersListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<Users, DeleteUsersResponse>();

            CreateMap<Users, GetUsersByIdResponse>();

            CreateMap<UpdateUsersRequest, Users>();
            CreateMap<Users, UpdateUsersResponse>();
        }

    }
    
}
