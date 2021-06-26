using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x =>x.UserName).NotEmpty().WithMessage("Kullanıcı adınızı giriniz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifrenizi giriniz");
            RuleFor(x => x.UserName).MinimumLength(2);
        }
    }
}
