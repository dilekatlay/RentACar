using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.FluentValidation.Model;
using Business.Request.Brand;
using Business.Request.Model;
using Business.Responses.Brand;
using Business.Responses.Model;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        private readonly BrandBusinessRules _brandBusinessRules;
        private IMapper _mapper;

        public BrandManager(IBrandDal brandDal, BrandBusinessRules brandBusinessRules, IMapper mapper)
        {
            _brandDal = brandDal;//new InMemoryDal(); // başka katmanların classları newlenmez. bu yüzden dependency injection 
            _brandBusinessRules = brandBusinessRules;
            _mapper = mapper;
        }

        public AddBrandResponse Add(AddBrandRequest request)
        {
            ValidationTool.Validate(new AddModelRequestValidator(), request);
            // İş Kuralları
            _brandBusinessRules.CheckIfBrandNameNotExists(request.Name);
            // Validation
            // Yetki kontrolü
            // Cache
            // Transaction
            //Brand brandToAdd = new(request.Name)
            Brand brandToAdd = _mapper.Map<Brand>(request); // Mapping

            _brandDal.Add(brandToAdd);

            AddBrandResponse response = _mapper.Map<AddBrandResponse>(brandToAdd);
            return response;
        }

        public DeleteBrandResponse Delete(DeleteBrandRequest request)
        {
            Brand? brandToDelete = _brandDal.Get(predicate: brand => brand.Id == request.Id); // 0x123123
            _brandBusinessRules.CheckIfBrandExists(brandToDelete); // 0x123123

            Brand deletedBrand = _brandDal.Delete(brandToDelete!); // 0x123123

            var response = _mapper.Map<DeleteBrandResponse>(
                deletedBrand // 0x123123
            );
            return response;
        }

       

        public GetBrandByIdResponse GetById(GetBrandByIdRequest request)
        {
            Brand? brand = _brandDal.Get(predicate: brand => brand.Id == request.Id);
            _brandBusinessRules.CheckIfBrandExists(brand);

            var response = _mapper.Map<GetBrandByIdResponse>(brand);
            return response;
        }




        public GetBrandListResponse GetList(GetBrandListRequest request)
        {
          

            IList<Brand> brandList = _brandDal.GetList();

           

            GetBrandListResponse response = _mapper.Map<GetBrandListResponse>(brandList); // Mapping
            return response;
        }

        public UpdateBrandResponse Update(UpdateBrandRequest request)
        {
            Brand? brandToUpdate = _brandDal.Get(predicate: brand => brand.Id == request.Id); // 0x123123
            _brandBusinessRules.CheckIfBrandExists(brandToUpdate);

            brandToUpdate = _mapper.Map(request, brandToUpdate); // 0x123123
            Brand updatedBrand = _brandDal.Update(brandToUpdate!); // 0x123123

            var response = _mapper.Map<UpdateBrandResponse>(
                updatedBrand // 0x123123
            );
            return response;
        }

      



    }
}