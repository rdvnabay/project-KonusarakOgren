using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private IArticleDal _articleDal;
        private IMapper _mapper;
        public ArticleManager(IArticleDal articleDal, IMapper mapper)
        {
            _articleDal = articleDal;
            _mapper = mapper;
        }
        public void Add(Article article)
        {
            _articleDal.Add(article);
        }

        public void DeleteById(int articleId)
        {
            var article = _articleDal.Get(x =>x.Id==articleId);
            _articleDal.Delete(article);
        }

        public List<ArticleDto> GetAll()
        {
            var articles= _articleDal.GetAll();
            var articlesDto = _mapper.Map<List<ArticleDto>>(articles);
            return articlesDto;
        }

        public List<string> GetAllByTitle()
        {
          var titles= _articleDal.GetAll().Select(x => x.Title).ToList();
          return titles;
        }

        public Article GetArticleAndQuizzes(int articleId)
        {
            return _articleDal.GetArticleAndQuizzes(articleId);
        }
    }
}
