

using ConsoleApp2.Model;

internal class Program
{
        private static void Main(string[] args)
    {
        Klient Adam_Kowalski = new Klient
        {
            Id = Guid.NewGuid(),
            Imie = "Jan",
            Nazwisko = "Kowalski",
            KontaktDoKlienta = new Kontakt
            {
                Adres = "ul. Przykładowa 1",
                Telefon = "123456789",
                Email = "",
                Miasto = "Warszawa",
                }
        };
        Pracownik pracownik = new Pracownik();
        pracownik.SpecjalizacjaPracownika=Specjalizacja.Mechanik;
        pracownik.Imie = "Adam";
        pracownik.Nazwisko = "Nowak";
        pracownik.KontaktDoPracownika = new Kontakt
        {
            Adres = "ul. Przykładowa 2",
            Telefon = "987654321",
            Email = ""};

        Samochod samochod = new Samochod
        {
            Id = Guid.NewGuid(),
            Marka = "Toyota",
            Model = "Corolla",
            RokProdukcji = 2020,
            NumerRejestracyjny = "ABC1234",
            NumerVin = "1HGCM82633A123456",
            Wlasciciel = Adam_Kowalski,
            StanSamochodu = Stan.Uzywany
        };

        Zgloszenie rozbiteAuto = new Zgloszenie
        {
            Id = Guid.NewGuid(),
            SerwisowanySamochod = samochod,
            DataPrzyjecia = DateTime.Now,
            StatusZgloszenia = "W trakcie naprawy",
            ZakresDzialan = "Naprawa zderzaka"
        };
        Zadanie wymianaZderzaka = new Zadanie
        {
            Id = Guid.NewGuid(),
            ZgloszenieSamochodu = rozbiteAuto,
            pracownikZakladu = pracownik,
            OpisZadania = "Wymiana zderzaka",
            ZakresDzialan = "Wymiana zderzaka",
            CzesciZamienne = new List<CzescZamienna>
            {
                new CzescZamienna
                {
                    Id = Guid.NewGuid(),
                    NazwaCzesci = "Zderzak przedni",
                    NumerCzesci = "ZZ1234",
                    CenaCzesci = 500.00m,
                    IloscCzesci = 1
                }
            }
        };
        wymianaZderzaka.CzesciZamienne.Add(new CzescZamienna
        {
            Id = Guid.NewGuid(),
            NazwaCzesci = "Śrubki mocujące",
            NumerCzesci = "ZZ5678",
            CenaCzesci = 30m,
            IloscCzesci = 10
        });
        
        foreach (var czesc in wymianaZderzaka.CzesciZamienne)
        {
            Console.WriteLine($"{czesc.Id}\n Część: {czesc.NazwaCzesci}, Cena: {czesc.CenaCzesci}, Ilość: {czesc.IloscCzesci}\n");
        }
    }
}