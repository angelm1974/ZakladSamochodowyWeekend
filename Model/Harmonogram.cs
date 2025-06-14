namespace ConsoleApp2.Model
{
    public struct Harmonogram
    {
        public Guid Id { get; set; }
        public Zgloszenie ZgloszenieSamochodu { get; set; }
        public string StanowiskoPracy { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataStop { get; set; }
    }

}