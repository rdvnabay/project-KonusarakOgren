using Entities.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WebUI.Models
{
    public class CorrectAnswerModel
    {
        public List<QuizAddDto> quizAddDto { get; set; }
        public List<SelectListItem> CorrectAnswers { set; get; }
    }
}
