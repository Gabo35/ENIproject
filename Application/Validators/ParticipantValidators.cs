
using FluentValidation;

namespace Application.Validators
{
    public class ParticipantValidators : AbstractValidator<ParticipantDto>
    {
        public ParticipantValidators()
        {
            RuleFor(x => x.Nom).NotNull();
            RuleFor(x => x.Prenom).NotNull();
            RuleFor(x => x.RoleId).GreaterThan(0).WithMessage("Veuillez renseigner le rôle");
            RuleFor(x => x.Mail).Matches("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$").NotNull().NotEmpty();
        }
    }
}
