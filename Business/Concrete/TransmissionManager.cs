﻿using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Transmission;
using Business.Responses.Transmission;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TransmissionManager : ITransmissionService
    {
        private readonly ITransmissionDal _transmissionDal;
        private readonly TransmissionBusinessRules _transmissionBusinessRules;
        private IMapper _mapper;
        public TransmissionManager(ITransmissionDal transmissionDal, TransmissionBusinessRules transmissionBusinessRules, IMapper mapper)
        {
            _transmissionDal = transmissionDal;
            _transmissionBusinessRules = transmissionBusinessRules;
            _mapper = mapper;
        }
        public AddTransmissionResponse Add(AddTransmissionRequest request)
        {
            _transmissionBusinessRules.CheckIfNameTransmissionNameExists(request.Name);
            Transmission transmissionToAdd = _mapper.Map<Transmission>(request);
            _transmissionDal.Add(transmissionToAdd);
            AddTransmissionResponse response = _mapper.Map<AddTransmissionResponse>(transmissionToAdd);
            return response;


        }

        public DeleteTransmissionResponse Delete(DeleteTransmissionRequest request)
        {
            Transmission? transmissionToDelete = _transmissionDal.Get(predicate: transmission => transmission.Id == request.Id);
            _transmissionBusinessRules.CheckIfTransmissionExists(transmissionToDelete);
            Transmission deletedTransmission = _transmissionDal.Delete(transmissionToDelete!);
            DeleteTransmissionResponse response = _mapper.Map<DeleteTransmissionResponse>(deletedTransmission);
            return response;

        }

      

        public GetTransmissionByIdResponse GetById(GetTransmissionByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public GetTransmissionListResponse GetList(GetTransmissionListRequest request)
        {
            IList<Transmission> transmissionList = _transmissionDal.GetList();
            GetTransmissionListResponse response = _mapper.Map<GetTransmissionListResponse>(transmissionList);
            return response;
        }

       

        public UpdateTransmissionResponse Update(UpdateTransmissionRequest request)
        {
            Transmission? transmissionToUpdate = _transmissionDal.Get(predicate: transmission => transmission.Id == request.Id);
            _transmissionBusinessRules.CheckIfTransmissionExists(transmissionToUpdate);
            transmissionToUpdate = _mapper.Map(request, transmissionToUpdate);
            Transmission updatedTransmission = _transmissionDal.Update(transmissionToUpdate);
            var response = _mapper.Map<UpdateTransmissionResponse>(updatedTransmission);
            return response;
        }
    }
}
