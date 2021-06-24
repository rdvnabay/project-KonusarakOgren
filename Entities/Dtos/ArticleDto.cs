using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
   public class ArticleDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
