
using FluentValidation;

namespace Application.Validators
{
    public class LieuValidators : AbstractValidator<LieuDto>
    {
        public LieuValidators()
        {
  
            RuleFor(x => x.Etablissement).NotNull();
            RuleFor(x => x.Ville).NotNull();
            RuleFor(x => x.Adresse).NotNull();
            RuleFor(x => x.CodePostal).NotNull();
            RuleFor(x => x.CoordonneesGPS).NotNull();

        }
    }
}
