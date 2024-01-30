using AutoMapper;
using Business.Dtos.Customers;
using Business.Dtos.Fuel;
using Business.Dtos.IndividualCustomer;
using Business.Request.Fuel;
using Business.Responses.Fuel;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class IndividualCustomerMapperProfiles : Profile
    {
        public IndividualCustomerMapperProfiles()
        {
            CreateMap<AddIndividualCustomerRequest, IndividualCustomer>();
            CreateMap<IndividualCustomer, AddIndividualCustomerResponse>();

            CreateMap<IndividualCustomer, IndividualCustomerListItemDto>();
            CreateMap<IList<IndividualCustomer>, GetIndividualCustomerListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<IndividualCustomer, DeleteIndividualCustomerResponse>();

            CreateMap<IndividualCustomer, GetIndividualCustomerByIdResponse>();

            CreateMap<UpdateIndividualCustomerRequest, IndividualCustomer>();
            CreateMap<IndividualCustomer, UpdateIndividualCustomerResponse>();
        }

    }
}
