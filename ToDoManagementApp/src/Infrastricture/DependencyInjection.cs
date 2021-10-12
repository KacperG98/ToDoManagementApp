using Infrastricture.Config;
using Infrastricture.Config.Interfaces;
using Infrastricture.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Infrastricture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFrameworkNpgsql();
            services.AddDbContext<TaskContext>(opt =>
                    opt.UseNpgsql(configuration.GetConnectionString("TaskDatabase"))
                );

            services.Configure<UserDatabaseConfig>(_ =>
                configuration.GetSection(nameof(UserDatabaseConfig)));

            services.AddSingleton<IUserDatabaseConfig>(sp =>
                sp.GetRequiredService<IOptions<UserDatabaseConfig>>().Value);


            return services;
        }
    }
}
