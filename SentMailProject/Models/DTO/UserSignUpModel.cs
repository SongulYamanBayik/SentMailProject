using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SentMailProject.Models.DTO
{
    public class UserSignUpModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Lütfen Kullanıcı Adı Giriniz.")]
        [MinLength(3,ErrorMessage ="Kullanıcı Adı En Az 3 Karakter Olmalıdır.")]
        [MaxLength(25,ErrorMessage ="Kullanıcı Adı En Fazla 25 Karakter Olmalıdır.")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen Mail Adresi Giriniz.")]
        [EmailAddress(ErrorMessage ="Geçerli Bir Mail Adresi Giriniz.")]
        [Display(Name ="Mail Adresi")]
        public string Mail { get; set; }

        [Required(ErrorMessage ="Lütfen Şifre Giriniz.")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Lütfen Şifreyi Tekrar Giriniz.")]
        [Display(Name ="Şifre Tekrar")]
        [Compare("Password", ErrorMessage ="Şifreler Uyuşmuyor")]
        
        public string ConfirmPassword { get; set; }
    }
}
