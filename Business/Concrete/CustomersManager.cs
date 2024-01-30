using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.FluentValidation.Customers;
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
    public class CustomersManager : ICustomersService
    {
        private readonly ICustomersDal _customersDal;
        private readonly CustomersBusinessRules _customersBusinessRules;
        private IMapper _mapper;

        public CustomersManager(ICustomersDal customersDal, CustomersBusinessRules customersBusinessRules, IMapper mapper)
        {
            _customersDal = customersDal;
            _customersBusinessRules = customersBusinessRules;
            _mapper = mapper;
        }

        public AddCustomersResponse Add(AddCustomersRequest request)
        {
            ValidationTool.Validate(new AddCustomersRequestValidator(), request);
            Customers customersToAdd = _mapper.Map<Customers>(request);
            _customersDal.Add(customersToAdd);
            AddCustomersResponse response = _mapper.Map<AddCustomersResponse>(request);
            return response;
        }

        public DeleteCustomersResponse Delete(DeleteCustomersRequest request)
        {
            Customers? customersToDelete = _customersDal.Get(predicate: customers => customers.Id == request.Id);
            _customersBusinessRules.CheckIfCustomersExists(customersToDelete);
            Customers deletedCustomers = _customersDal.Delete(customersToDelete!);
            DeleteCustomersResponse response = _mapper.Map<DeleteCustomersResponse>(deletedCustomers);
            return response;
        }

        public GetCustomersByIdResponse GetById(GetCustomersByIdRequest request)
        {
            Customers? customers = _customersDal.Get(predicate: customers => customers.Id == request.Id);
            _customersBusinessRules.CheckIfCustomersExists(customers);
            GetCustomersByIdResponse response = _mapper.Map<GetCustomersByIdResponse>(customers);
            return response;
        }

        public GetCustomersListResponse GetList(GetCustomersListRequest request)
        {
            IList<Customers> customersList = _customersDal.GetList(
                predicate: customers => (request.FilterByUserId == null || customers.UserId == request.FilterByUserId));
            var response = _mapper.Map<GetCustomersListResponse>(customersList);
            return response;
        }

        public UpdateCustomersResponse Update(UpdateCustomersRequest request)
        {
            Customers? customersToUpdate = _customersDal.Get(predicate: customers => customers.Id == request.Id);
            _customersBusinessRules.CheckIfCustomersExists(customersToUpdate);

            customersToUpdate = _mapper.Map(request, customersToUpdate);
            Customers updatedCustomers = _customersDal.Update(customersToUpdate!);
            var response = _mapper.Map<UpdateCustomersResponse>(updatedCustomers);
            return response;
        }
    }

}
