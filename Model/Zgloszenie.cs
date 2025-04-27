namespace ConsoleApp2.Model{
    public struct Zgloszenie
    {
        public Guid Id { get; set; }
        public Samochod SerwisowanySamochod { get; set; }
        public DateTime DataPrzyjecia{ get; set; }
        public string StatusZgloszenia { get; set; } 
        public string ZakresDzialan { get; set; }
    }}