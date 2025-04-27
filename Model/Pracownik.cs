namespace ConsoleApp2.Model{
    public struct Pracownik
    {
        //private string _nazwisko;
        public Guid Id { get; set; }
        public string Imie { get; set; }
         public string Nazwisko { get; set; }//{ get => _nazwisko; set => _nazwisko = (value ?? string.Empty).ToUpper(); }
        public Kontakt KontaktDoPracownika { get; set; }
        public Specjalizacja SpecjalizacjaPracownika { get; set; }
    }

    public enum Specjalizacja
    {
        Mechanik,
        Elektryk,
        Lakiernik,
        Blacharz,
        Diagnosta,
        Menadzer
    }
}