using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SentMailProject.Models.DTO
{
    public class UserSignInModel
    {
        [Required(ErrorMessage ="Kullanıcı Adı Alanı Boş Geçilemez.")]
        public string UserName { get; set; }


        [Required(ErrorMessage ="Şifre Alanı Boş Geçilemez.")]
        public string Password { get; set; }
    }
}
