using Core.Utilities.Results;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IResult Login(UserForLoginDto userForLoginDto);
    }
}
