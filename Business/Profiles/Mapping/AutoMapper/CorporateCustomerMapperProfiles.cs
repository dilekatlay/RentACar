using AutoMapper;
using Business.Dtos.Brand;
using Business.Dtos.CorporateCustomer;
using Business.Request.Brand;
using Business.Requests.Model;
using Business.Responses.Brand;
using Business.Responses.Model;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class CorporateCustomerMapperProfiles : Profile
    {
        public CorporateCustomerMapperProfiles()
        {
            CreateMap<AddCorporateCustomerRequest, CorporateCustomer>();
            CreateMap<CorporateCustomer, AddCorporateCustomerResponse>();

            CreateMap<CorporateCustomer, CorporateCustomerListItemDto>();
            CreateMap<IList<CorporateCustomer>, GetCorporateCustomerListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<CorporateCustomer, DeleteCorporateCustomerResponse>();

            CreateMap<CorporateCustomer, GetCorporateCustomerByIdResponse>();

            CreateMap<UpdateCorporateCustomerRequest, CorporateCustomer>();
            CreateMap<CorporateCustomer, UpdateCorporateCustomerResponse>();
        }
        
    }


}
