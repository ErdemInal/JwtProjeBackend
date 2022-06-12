using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using JwtProje.Business.Concrete;
using JwtProje.Business.Interfaces;
using JwtProje.Business.ValidationRules.FluentValidation;
using JwtProje.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using JwtProje.DataAccess.Interfaces;
using JwtProje.Entities.Dtos.AppUserDtos;
using JwtProje.Entities.Dtos.ProductDtos;

namespace JwtProje.Business.Containers.MicrosoftIoc
{
    public static class CustomExtension
    {

        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));

            services.AddScoped<IProductDal, EfProductRepository>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<IAppUserDal, EfAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<IAppRoleDal, EfAppRoleRepository>();
            services.AddScoped<IAppRoleService, AppRoleManager>();

            services.AddScoped<IAppUserRoleDal, EfAppUserRoleRepository>();
            services.AddScoped<IAppUserRoleService, AppUserRoleManager>();

            services.AddScoped<IJwtService, JwtManager>();

            services.AddTransient<IValidator<ProductAddDto>, ProductAddDtoValidator>();
            services.AddTransient<IValidator<ProductUpdateDto>, ProductUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginDtoValidator>();

            services.AddTransient<IValidator<AppUserAddDto>, AppUserAddDtoValidator>();
        }
    }

}
