namespace ConsoleApp2.Model{
    public struct Zadanie
    {
        public Guid Id { get; set; }
        public Zgloszenie ZgloszenieSamochodu { get; set; }
        public Pracownik pracownikZakladu{ get; set; }
        public string OpisZadania { get; set; } 
        public string ZakresDzialan { get; set; }
        public List<CzescZamienna> CzesciZamienne { get; set; }

        public Zadanie()
        {
            Id = Guid.NewGuid();
            ZgloszenieSamochodu = default;
            pracownikZakladu = default;
            OpisZadania = string.Empty;
            ZakresDzialan = string.Empty;
            CzesciZamienne = new List<CzescZamienna>();
        }
    }
    
    public struct CzescZamienna
    {
        public Guid Id { get; set; }
        public string NazwaCzesci { get; set; }
        public string NumerCzesci { get; set; }
        public decimal CenaCzesci { get; set; }
        public int IloscCzesci { get; set; }
    }
}