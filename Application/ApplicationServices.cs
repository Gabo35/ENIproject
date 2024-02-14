using Microsoft.Extensions.DependencyInjection;
using Application.Services;
using Domaine.Entities;
using FluentValidation;
using Application.Validators;

namespace SortieApp.Application
{
    public static class ApplicationServices
    {
        public static IServiceCollection ConfigureApplicationService(this IServiceCollection services)
        {
            services.AddScoped<ISortieServices, SortieServices>();
            services.AddScoped<IRoleServices, RoleServices>();
            services.AddScoped<IEtatServices, EtatServices>();
            services.AddScoped<ILieuServices, LieuServices>();
            services.AddScoped<IInscriptionServices, InscriptionServices>();
            services.AddScoped<IParticipantServices, ParticipantServices>();

            services.AddAutoMapper(configurations => configurations.CreateMap<SortieDto, Sortie>());
            services.AddAutoMapper(configurations => configurations.CreateMap<EtatDto, Etat>());
            services.AddAutoMapper(configurations => configurations.CreateMap<InscriptionDto, Inscription>());
            services.AddAutoMapper(configurations => configurations.CreateMap<LieuDto, Lieu>());
            services.AddAutoMapper(configurations => configurations.CreateMap<ParticipantDto, Participant>());
            services.AddAutoMapper(configurations => configurations.CreateMap<RoleDto, Role>());

            services.AddScoped<IValidator<ParticipantDto>, ParticipantValidators>();
            services.AddScoped<IValidator<EtatDto>, EtatValidators>();
            services.AddScoped<IValidator<InscriptionDto>, InscriptionValidators>();
            services.AddScoped<IValidator<LieuDto>, LieuValidators>();
            services.AddScoped<IValidator<RoleDto>, RoleValidators>();
            services.AddScoped<IValidator<SortieDto>, SortieValidators>();

            return services;
        }
    }
}
