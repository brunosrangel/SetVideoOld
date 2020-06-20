using setVideo.Repository;
using setVideo.Service;
using Microsoft.Extensions.DependencyInjection;
using setVideo.WebApi.Controllers;

namespace setVideo.WebApi.Container
{
    public static class ContainerBuilder
    {
        public static void ConfigureContainer(IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ICustomerServices, CustomerServices>();
            services.AddTransient<ICustomerController, CustomerController>();
        }
    }
}
