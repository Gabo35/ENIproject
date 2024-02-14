
using FluentValidation;

namespace Application.Validators
{
    public class SortieValidators : AbstractValidator<SortieDto>
    {
        public SortieValidators()
        {
  
            RuleFor(x => x.Nom).NotNull();
            RuleFor(x => x.DateDebut).NotNull();
            RuleFor(x => x.DateFin).NotNull();
            RuleFor(x => x.OrganisateurId).GreaterThan(0).WithMessage("Veuillez renseigner le numéro de l'organisateur");
            RuleFor(x => x.LieuId).GreaterThan(0).WithMessage("Veuillez renseigner le numéro du lieu");
            RuleFor(x => x.EtatId).GreaterThan(0).WithMessage("Veuillez renseigner le numéro de l'état");

        }
    }
}
