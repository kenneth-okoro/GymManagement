using GymManagement.Application.Common.Interfaces;
using GymManagement.Infrastructure.Common.Persistence;
using GymManagement.Infrastructure.Subscriptions.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<GymManagementDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("GymManagementDbConnectionString")));

            services.AddScoped<IUnitOfWork>(servicProvider => 
                servicProvider.GetRequiredService<GymManagementDbContext>());
            services.AddScoped<ISubscriptionsRepository, SubscriptionRepository>();

            return services;
        }

    }
}
