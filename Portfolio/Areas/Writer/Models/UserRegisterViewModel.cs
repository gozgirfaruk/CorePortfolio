using System.ComponentModel.DataAnnotations;

namespace Portfolio.UI.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string Surname { get; set; }


        [Required(ErrorMessage ="Lütfen Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Lütfen Resim Url Boş Geçilemez")]
        public string ImageUrl { get; set; }



        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Şifreler Eşleştirilemedi.")]
        public string  ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Giriniz")]
        public string Mail { get; set; }

    }
}
