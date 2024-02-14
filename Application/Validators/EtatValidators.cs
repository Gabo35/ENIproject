
using FluentValidation;

namespace Application.Validators
{
    public class EtatValidators : AbstractValidator<EtatDto>
    {
        public EtatValidators()
        {
  
            RuleFor(x => x.Libelle).NotNull();
            
        }
    }
}
