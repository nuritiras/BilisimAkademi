namespace BilisimAkademi.Models
{
    public class Aday
    {
        public String? Eposta {get;set;}=String.Empty;
        public String? Isim {get;set;}=String.Empty;
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