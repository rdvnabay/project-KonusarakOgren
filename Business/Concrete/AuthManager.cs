using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using Entities.Dtos;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Login(UserForLoginDto userForLoginDto)
        {
            var user= _userService.getByUserName(userForLoginDto.UserName);
            if (user == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            else if(user.Password!=userForLoginDto.Password)
            {
                return new ErrorResult(Messages.WrongPassword);
            }

            return new SuccessResult(Messages.LoginSuccessful);
        }
    }
}
