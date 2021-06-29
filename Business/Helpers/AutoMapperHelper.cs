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
            CreateMap<Article, QuizAddDto>().ReverseMap();
            CreateMap<Article, ArticleDto>().ReverseMap();
            CreateMap<Article, ArticleAddDto>().ReverseMap();
            CreateMap<Quiz, QuizDto>().ReverseMap();
        }
    }
}
