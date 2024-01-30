using AutoMapper;
using Business.Dtos.Car;
using Business.Dtos.CorporateCustomer;
using Business.Dtos.Customers;
using Business.Request.Car;
using Business.Responses.Car;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class CustomersMapperProfiles : Profile
    {
        public CustomersMapperProfiles()
        {
            CreateMap<AddCustomersRequest, Customers>();
            CreateMap<Customers, AddCustomersResponse>();

            CreateMap<Customers, CustomersListItemDto>();
            CreateMap<IList<Customers>, GetCustomersListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<Customers, DeleteCustomersResponse>();

            CreateMap<Customers, GetCustomersByIdResponse>();

            CreateMap<UpdateCustomersRequest, Customers>();
            CreateMap<Customers, UpdateCustomersResponse>();
        }

    }

}
