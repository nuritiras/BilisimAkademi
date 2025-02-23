using System.ComponentModel.DataAnnotations;

namespace BilisimAkademi.Models
{
    public class Aday
    {
        [Required(ErrorMessage ="E-Posta alanı zorunlu.")]
        public String? Eposta {get;set;}=String.Empty;

        [Required(ErrorMessage ="İsim alanı zorunlu.")]
        public String? Isim {get;set;}=String.Empty;

        [Required(ErrorMessage ="Soyisim alanı zorunlu.")]
        public String? SoyIsim {get;set;}=String.Empty;
        public String? TamIsim => $"{Isim} {SoyIsim?.ToUpper()}";
        public int? Yas {get;set;}
        public String? SecilenKurs {get;set;}=String.Empty;
        public DateTime BasvuruZamani {get;set;}
        public Aday(){
            BasvuruZamani=DateTime.Now;
        }
    }
}