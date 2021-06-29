using Business.Constants;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x =>x.UserName).NotEmpty().WithMessage(ValidationMessage.EnterUserName);
            RuleFor(x => x.Password).NotEmpty().WithMessage(ValidationMessage.EnterPassword);
            RuleFor(x => x.UserName).MinimumLength(2);
        }
    }
}
