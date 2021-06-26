using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class QuizManager : IQuizService
    {
        private IQuizDal _quizDal;
        private IArticleService _articleService;
        private IMapper _mapper;
        public QuizManager(IQuizDal quizDal, IArticleService articleService, IMapper mapper)
        {
            _quizDal = quizDal;
            _articleService = articleService;
            _mapper =mapper;
        }

        //Command
        public void Add(QuizAddDto quizAddDto)
        {
            var quiz = _mapper.Map<Quiz>(quizAddDto);
            //var article=_mapper.Map<Article>(quizAddDto);
            //_articleService.Add(article);
            _quizDal.Add(quiz);
        }
        public void Delete(Quiz quiz)
        {
            _quizDal.Delete(quiz);
        }
        public void Update(Quiz quiz)
        {
            _quizDal.Update(quiz);
        }

        //Query

        public Quiz Get(int quizId)
        {
           return _quizDal.Get(x =>x.Id==quizId);
        }
        public List<Quiz> GetAll()
        {
            return _quizDal.GetAll();
        }

        public List<QuizDto> GetAllById(int articleId)
        {
            var quizzess= _quizDal.GetAll(x=>x.Id==articleId);
            var quizzesDto = _mapper.Map<List<QuizDto>>(quizzess);
            return quizzesDto;    
        }

        public void AddMultiple(List<QuizAddDto> quizAddDto)
        {
            var quizzes = _mapper.Map<List<Quiz>>(quizAddDto);
            foreach (var quiz in quizzes)
            {
                _quizDal.Add(quiz);
            }
        }

        public List<QuizDto> GetAllByArticle(int articleId)
        {
            var quizzes= _quizDal.GetAll(x => x.ArticleId == articleId);
            var quizzesDto = _mapper.Map<List<QuizDto>>(quizzes);
            return quizzesDto;
        }
    }
}
