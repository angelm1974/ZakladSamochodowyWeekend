namespace ConsoleApp2.Model{
    public struct Samochod
    {
        public Guid Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int RokProdukcji { get; set; }
        public string NumerRejestracyjny { get; set; }
        public string NumerVin { get; set; }
        public Klient Wlasciciel { get; set; }
        public Stan StanSamochodu { get; set; }

    }

    public enum Stan{
        Nowy,
        Uzywany,
        Uszkodzony,
        Sprawny,
        Zniszczony} 

    }