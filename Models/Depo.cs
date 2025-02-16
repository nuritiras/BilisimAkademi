namespace BilisimAkademi.Models
{
    public static class Depo
    {
        private static List<Aday> uygulamalar = new();
        public static IEnumerable<Aday> Uygulamalar => uygulamalar;
        public static void Ekle(Aday aday)
        {
            uygulamalar.Add(aday);
        }
    }
}