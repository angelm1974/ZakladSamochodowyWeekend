
namespace ConsoleApp2.Model{
    public struct Klient
    {
        public Guid Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Kontakt KontaktDoKlienta { get; set; }
    }

    public struct Kontakt
    {
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        
    }
}
