using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.FluentValidation.CorporateCustomer;
using Business.Profiles.Validation.FluentValidation.Model;
using Business.Responses.Model;
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
    public class CorporateCustomerManager : ICorporateCustomerService
    {
        private readonly ICorporateCustomerDal _corporateCustomerDal;
        private readonly CorporateCustomerBusinessRules _corporateCustomerBusinessRules;
        private IMapper _mapper;

        public CorporateCustomerManager(ICorporateCustomerDal corporateCustomerDal, CorporateCustomerBusinessRules corporateCustomerBusinessRules, IMapper mapper)
        {
            _corporateCustomerDal = corporateCustomerDal;//new InMemoryDal(); // başka katmanların classları newlenmez. bu yüzden dependency injection 
            _corporateCustomerBusinessRules = corporateCustomerBusinessRules;
            _mapper = mapper;
        }

        public AddCorporateCustomerResponse Add(AddCorporateCustomerRequest request)
        {
            // fluent validation
            ValidationTool.Validate(new AddCorporateCustomerRequestValidator(), request);
            CorporateCustomer corporateToAdd = _mapper.Map<CorporateCustomer>(request);
            _corporateCustomerDal.Add(corporateToAdd);
            AddCorporateCustomerResponse response = _mapper.Map<AddCorporateCustomerResponse>(request);
            return response;
        }

        public DeleteCorporateCustomerResponse Delete(DeleteCorporateCustomerRequest request)
        {
            CorporateCustomer? corporateTodelete = _corporateCustomerDal.Get(predicate: corporateCustomer => corporateCustomer.Id == request.Id);
            _corporateCustomerBusinessRules.CheckIfCorporateCustomerExists(corporateTodelete);
            CorporateCustomer deletedCorp = _corporateCustomerDal.Delete(corporateTodelete!);
            DeleteCorporateCustomerResponse response = _mapper.Map<DeleteCorporateCustomerResponse>(request);
            return response;
        }

        public GetCorporateCustomerByIdResponse GetById(GetCorporateCustomerByIdRequest request)
        {
            CorporateCustomer? corporateCustomer = _corporateCustomerDal.Get(predicate: corporateCustomer => corporateCustomer.Id == request.Id);
            _corporateCustomerBusinessRules.CheckIfCorporateCustomerExists(corporateCustomer);
            GetCorporateCustomerByIdResponse response = _mapper.Map<GetCorporateCustomerByIdResponse>(request);
            return response;
        }

        public GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request)
        {
            IList<CorporateCustomer> corpList = _corporateCustomerDal.GetList();
            GetCorporateCustomerListResponse response = _mapper.Map<GetCorporateCustomerListResponse>(corpList);
            return response;
        }

        public UpdateCorporateCustomerResponse Update(UpdateCorporateCustomerRequest request)
        {
            CorporateCustomer? corpToUpdate = _corporateCustomerDal.Get(predicate: corp => corp.Id == request.Id);
            _corporateCustomerBusinessRules.CheckIfCorporateCustomerExists(corpToUpdate);
            corpToUpdate = _mapper.Map(request, corpToUpdate);
            CorporateCustomer updatedCorp = _corporateCustomerDal.Update(corpToUpdate!);
            var response = _mapper.Map<UpdateCorporateCustomerResponse>(updatedCorp);
            return response;
        }
    }
}