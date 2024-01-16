using BCM.Infrastructure.Contracts;
using BCM.Infrastructure.CustomServices;
using BCM.Infrastructure.Helpers;
using BCM.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BCM.Infrastructure
{
    public static class InfrastructureServices
    {
        public static void ConfigureInfrastructureServices(this IServiceCollection services)
        {
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddHttpContextAccessor();

            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IUploadFileService, UploadFileService>();
        }
    }
}
