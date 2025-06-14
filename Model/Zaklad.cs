namespace ConsoleApp2.Model{
    public struct Zaklad
    {
        public static List<Pracownik> Pracownicy = new List<Pracownik>();
        public static string? Nazwa { get; set; }
        public static string? Adres { get; set; }
        public static string? KontaktDoZakladu { get; set; }
        public static List<Zgloszenie>? Zgloszenia { get; set; }

    }
    }