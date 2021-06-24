using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Helpers
{
    public class AutoMapperHelper:Profile
    {
        public AutoMapperHelper()
        {
            CreateMap<User, UserForLoginDto>().ReverseMap();
            CreateMap<Quiz, QuizAddDto>().ReverseMap();
        }
    }
}
