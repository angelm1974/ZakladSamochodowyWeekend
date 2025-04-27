namespace ConsoleApp2.Model{
    public struct Faktura
    {
        public Guid Id { get; set; }
        public Zgloszenie ZgloszenieFaktury { get; set; }
        public decimal KwotaFaktury { get; set; }
        public DateTime DataWystawienia { get; set; }
        public string NumerFaktury { get; set; }
    }
    }