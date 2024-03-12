using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;
using MediatrCQRSpattern.Application.Mappers;

namespace MediatrCQRSpattern.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
