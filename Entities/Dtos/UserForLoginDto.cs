using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public class UserForLoginDto
    {
        [Required(ErrorMessage = "Kullanıcı adı giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
