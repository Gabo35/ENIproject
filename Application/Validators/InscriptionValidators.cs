
using FluentValidation;

namespace Application.Validators
{
    public class InscriptionValidators : AbstractValidator<InscriptionDto>
    {
        public InscriptionValidators()
        {
  
            RuleFor(x => x.SortieId).GreaterThan(0).WithMessage("Veuillez renseigner le numéro de sortie");
            RuleFor(x => x.ParticipantId).GreaterThan(0).WithMessage("Veuillez renseigner le numéro du participant");

        }
    }
}
