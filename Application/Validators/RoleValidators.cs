
using FluentValidation;

namespace Application.Validators
{
    public class RoleValidators : AbstractValidator<RoleDto>
    {
        public RoleValidators()
        {
  
            RuleFor(x => x.Libelle).NotNull();
            
        }
    }
}
