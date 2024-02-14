using Infrastructure.Contexts;
using Infrastructure.Reporitories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SortieApp.Infrastructure
{
    public static class InfrastructureServices
    {
        public static IServiceCollection ConfigureInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped<ISortieRepository, SortieRepository>();
            services.AddDbContext<SortieContext>(option => option.UseSqlServer("Data Source=48SE46-1N5HHZ3;Initial Catalog=SORTIE;Persist Security Info=True;User ID=my_sql_user;Password=Pa$$w0rd;Trust Server Certificate=True"));
            
            services.AddScoped<IEtatRepository, EtatRepository>();
            services.AddDbContext<EtatContext>(option => option.UseSqlServer("Data Source=48SE46-1N5HHZ3;Initial Catalog=SORTIE;Persist Security Info=False;User ID=my_sql_user;Password=Pa$$w0rd;Trust Server Certificate=True"));
            
            services.AddScoped<ILieuRepository, LieuRepository>();
            services.AddDbContext<LieuContext>(option => option.UseSqlServer("Data Source=48SE46-1N5HHZ3;Initial Catalog=SORTIE;Persist Security Info=True;User ID=my_sql_user;Password=Pa$$w0rd;Trust Server Certificate=True"));
            
            services.AddDbContext<InscriptionContext>(option => option.UseSqlServer("Data Source=48SE46-1N5HHZ3;Initial Catalog=SORTIE;Persist Security Info=True;User ID=my_sql_user;Password=Pa$$w0rd;Trust Server Certificate=True"));
            services.AddScoped<IInscriptionRepository, InscriptionRepository>();

            services.AddScoped<IParticipantRepository, ParticipantRepository>();
            services.AddDbContext<ParticipantContext>(option => option.UseSqlServer("Data Source=48SE46-1N5HHZ3;Initial Catalog=SORTIE;Persist Security Info=True;User ID=my_sql_user;Password=Pa$$w0rd;Trust Server Certificate=True"));
            
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddDbContext<RoleContext>(option => option.UseSqlServer("Data Source=48SE46-1N5HHZ3;Initial Catalog=SORTIE;Persist Security Info=True;User ID=my_sql_user;Password=Pa$$w0rd;Trust Server Certificate=True"));

            //services.AddSingleton<SortieRepository>();
            //services.AddSingleton<SortieContext>();
            return services;
        }
    }
}
