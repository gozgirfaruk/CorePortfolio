using System.ComponentModel.DataAnnotations;

namespace Portfolio.UI.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı Adı Giriniz..")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifrenizi Giriniz..")]
        public string Password { get; set; }
    }
}
