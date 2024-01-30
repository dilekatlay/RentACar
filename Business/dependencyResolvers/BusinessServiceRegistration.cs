﻿using System.Reflection;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Concrete.InMemory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolvers;

public static class ServiceCollectionBusinessExtension
{
    // Extension method
    // Metodun ve barındığı class'ın static olması gerekiyor
    // İlk parametere genişleteceğimiz tip olmalı ve başında this keyword'ü olmalı.
    public static IServiceCollection AddBusinessServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddScoped<IBrandService, BrandManager>()
            .AddScoped<IBrandDal, EfBrandDal>()
            .AddScoped<BrandBusinessRules>();
        services
            .AddScoped<ICarService, CarManager>()
            .AddScoped<ICarDal, EfCarDal>()
            .AddScoped<CarBusinessRules>();
        services
            .AddScoped<IFuelService, FuelManager>()
            .AddScoped<IFuelDal, EfFuelDal>()
            .AddScoped<FuelBusinessRules>();
        services
            .AddScoped<ITransmissionService, TransmissionManager>()
            .AddScoped<ITransmissionDal, EfTransmissionDal>()
            .AddScoped<TransmissionBusinessRules>();
        services
            .AddScoped<IUsersService, UsersManager>()
            .AddScoped<IUsersDal, EfUsersDal>()
            .AddScoped<UsersBusinessRules>();
        services
            .AddScoped<ICustomersService, CustomersManager>()
            .AddScoped<ICustomersDal, EfCustomersDal>()
            .AddScoped<CustomersBusinessRules>();
        services
            .AddScoped<IIndividualCustomerService, IndividualCustomerManager>()
            .AddScoped<IIndividualCustomerDal, EfIndividualCustomerDal>()
            .AddScoped<IndividualCustomerBusinessRules>();
        services
            .AddScoped<ICorporateCustomerService, CorporateCustomerManager>()
            .AddScoped<ICorporateCustomerDal, EfCorporateCustomerDal>()
            .AddScoped<CorporateCustomerBusinessRules>();
        // Fluent
        // Singleton: Tek bir nesne oluşturur ve herkese onu verir.
        // Ek ödev diğer yöntemleri araştırınız.

        services
            .AddScoped<IModelService, ModelManager>()
            .AddScoped<IModelDal, EfModelDal>()
            .AddScoped<ModelBusinessRules>(); // Fluent

        services.AddAutoMapper(Assembly.GetExecutingAssembly()); // AutoMapper.Extensions.Microsoft.DependencyInjection NuGet Paketi
        // Reflection yöntemiyle Profile class'ını kalıtım alan tüm class'ları bulur ve AutoMapper'a ekler.

        services.AddDbContext<RentACarContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("RentACarMSSQL22"))
        );

        return services;
    }
}