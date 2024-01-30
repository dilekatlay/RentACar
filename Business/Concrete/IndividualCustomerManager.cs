using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
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
    public class IndividualCustomerManager : IIndividualCustomerService
    {
        private readonly IIndividualCustomerDal _individualCustomerDal;
        private readonly IndividualCustomerBusinessRules _individualCustomerBusinessRules;
        private IMapper _mapper;
        public IndividualCustomerManager(IIndividualCustomerDal individualCustomerDal, IndividualCustomerBusinessRules individualCustomerBusinessRules, IMapper mapper)
        {
            _individualCustomerDal = individualCustomerDal;
            _individualCustomerBusinessRules = individualCustomerBusinessRules;
            _mapper = mapper;
        }

        public AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request)
        {
            IndividualCustomer individualCustomerToAdd = _mapper.Map<IndividualCustomer>(request);
            _individualCustomerDal.Add(individualCustomerToAdd);
            AddIndividualCustomerResponse response = _mapper.Map<AddIndividualCustomerResponse>(individualCustomerToAdd);
            return response;
        }

        public DeleteIndividualCustomerResponse Delete(DeleteIndividualCustomerRequest request)
        {
            IndividualCustomer? individualCustomerToDelete = _individualCustomerDal.Get(predicate: ind => ind.Id == request.Id);
            _individualCustomerBusinessRules.CheckIfIndividualCustomerExists(individualCustomerToDelete);
            IndividualCustomer deletedIndiv = _individualCustomerDal.Delete(individualCustomerToDelete!);
            DeleteIndividualCustomerResponse response = _mapper.Map<DeleteIndividualCustomerResponse>(deletedIndiv);
            return response;
        }

        public GetIndividualCustomerByIdResponse GetById(GetIndividualCustomerByIdRequest request)
        {
            IndividualCustomer? indiv = _individualCustomerDal.Get(predicate: ind => ind.Id == request.Id);
            _individualCustomerBusinessRules.CheckIfIndividualCustomerExists(indiv);
            GetIndividualCustomerByIdResponse response = _mapper.Map<GetIndividualCustomerByIdResponse>(indiv);
            return response;
        }

        public GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request)
        {
            IList<IndividualCustomer> indivList = _individualCustomerDal.GetList(
                predicate: indiv => (request.FilterByCustomersId == null || indiv.CustomersId == request.FilterByCustomersId));


            GetIndividualCustomerListResponse response = _mapper.Map<GetIndividualCustomerListResponse>(indivList);
            return response;
        }

        public UpdateIndividualCustomerResponse Update(UpdateIndividualCustomerRequest request)
        {
            IndividualCustomer? indivToUpdate = _individualCustomerDal.Get(predicate: ind => ind.Id == request.Id);
            _individualCustomerBusinessRules.CheckIfIndividualCustomerExists(indivToUpdate);

            indivToUpdate = _mapper.Map(request, indivToUpdate);
            IndividualCustomer updatedIndiv = _individualCustomerDal.Update(indivToUpdate!);
            var response = _mapper.Map<UpdateIndividualCustomerResponse>(updatedIndiv);
            return response;
        }
    }
}
