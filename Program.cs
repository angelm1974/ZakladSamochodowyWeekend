using System.Data.SQLite;

using ConsoleApp2.Model;

internal class Program
{

    private static void Main(string[] args)
    {
        // Initialize the database connection
        SQLiteConnection connection = new SQLiteConnection("Data Source=serwis.db;Version=3;");
        connection.Open();
        new SQLiteCommand("CREATE TABLE IF NOT EXISTS Pracownicy (Id TEXT PRIMARY KEY, Imie TEXT, Nazwisko TEXT, Specjalizacja TEXT, KontaktAdres TEXT, KontaktTelefon TEXT, KontaktEmail TEXT)", connection).ExecuteNonQuery();
        new SQLiteCommand("CREATE TABLE IF NOT EXISTS Klienci (Id TEXT PRIMARY KEY, Imie TEXT, Nazwisko TEXT, KontaktAdres TEXT, KontaktTelefon TEXT, KontaktEmail TEXT, KontaktMiasto TEXT)", connection).ExecuteNonQuery();
        new SQLiteCommand("Create Table if not exists Zaklad (Id TEXT PRIMARY KEY, Nazwa TEXT, Adres TEXT, KontaktDoZakladu TEXT)", connection).ExecuteNonQuery();


        var readerCmd = new SQLiteCommand("SELECT * FROM Zaklad where Id = 1", connection);
        using (var reader = readerCmd.ExecuteReader())
        {
            if (!reader.HasRows)
            {
               Console.WriteLine("Brak danych w tabeli Zaklad...");
            }
            else
            {
                {
                    while (reader.Read())
                    {
                        // Zaklad.Id = Guid.Parse(reader["Id"].ToString());
                        Zaklad.Nazwa = reader["Nazwa"].ToString();
                        Zaklad.Adres = reader["Adres"].ToString();
                        Zaklad.KontaktDoZakladu = reader["KontaktDoZakladau"].ToString();
                        Console.WriteLine($"Zakład: {Zaklad.Nazwa}, Adres: {Zaklad.Adres}, Kontakt: {Zaklad.KontaktDoZakladu}");
                    }
                }
            }
        }
        //Zaklad.Nazwa= "AutoSerwis";
        //Zaklad.Adres = "ul. Serwisowa 10, Warszawa";
        //Zaklad.KontaktDoZakladu = "327648723";
        Zaklad.Pracownicy = new List<Pracownik>();
        Zaklad.Zgloszenia = new List<Zgloszenie>();
        Console.WriteLine("Witaj w systemie zarządzania serwisem samochodowym!");
        Console.WriteLine($"Nazwa zakładu: {Zaklad.Nazwa}");
        Console.WriteLine($"Adres zakładu: {Zaklad.Adres}");
        Console.WriteLine($"Kontakt do zakładu: {Zaklad.KontaktDoZakladu}");
        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
        Console.ReadKey();
        CUI.displayUI();

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
        pracownik.SpecjalizacjaPracownika = Specjalizacja.Mechanik;
        pracownik.Imie = "Adam";
        pracownik.Nazwisko = "Nowak";
        pracownik.KontaktDoPracownika = new Kontakt
        {
            Adres = "ul. Przykładowa 2",
            Telefon = "987654321",
            Email = ""
        };

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