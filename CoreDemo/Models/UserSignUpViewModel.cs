using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Lütfen Ad Soyad giriniz.")]
        public string NameSurname { get; set; }

        [Display(Name="Şifre")]
        [Required(ErrorMessage ="Lütfen şifrenizi giriniz.")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lütfen Mail adresinizi giriniz.")]
        public string Mail { get; set; }

        [Display(Name = "Kullanıcı adı")]
        [Required(ErrorMessage = "Kullanıcı Adı giriniz.")]
        public string UserName { get; set; }
    }
}
