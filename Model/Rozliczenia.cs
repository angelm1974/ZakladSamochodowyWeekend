namespace ConsoleApp2.Model{
    public struct Rozliczenia
    {
        public Guid Id { get; set; }
        public int Rok { get; set; }
        public int Miesiac { get; set; }
        public decimal Przychod { get; set; }
        public List<Zgloszenie> Zgloszenia { get; set; }
    }
}
    