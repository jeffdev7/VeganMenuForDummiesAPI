using Application.Interfaces.Services;
using Application.Services;
using Domain.Interfaces.Repositories;
using Infrastructure.DBConfiguration;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.IoC
{
    public class DI
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Repos
            services.AddScoped<IFoodRepository, FoodRepository>();

            //services
            services.AddScoped<IFoodServices, FoodServices>();
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            //services.AddTransient<IAppDbContext, ApplicationContext>();
        }

       
    }
}
