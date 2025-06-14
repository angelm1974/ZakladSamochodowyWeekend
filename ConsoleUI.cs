using System.Linq.Expressions;
using ConsoleApp2.Model;

internal class CUI
{
    // Static instance to store zaklad settings across method calls
    

    public static void displayUI()
    {
        while (true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("1. Dodaj pracownika");
                Console.WriteLine("2. Dodaj klienta");
                Console.WriteLine("3. Ustawienia");
                Console.WriteLine("4. Wyświetl ustawienia");
                Console.WriteLine("5. Wyjście");
                Console.Write("Wybierz opcję (1-3): ");
                string input = Console.ReadLine()!;

                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Dodaj pracownika");
                            Pracownik nowyPracownik = new Pracownik();

                            Console.Write("Wprowadź imię pracownika: ");
                            nowyPracownik.Imie = Console.ReadLine() ?? "Imię Pracownika";
                            Console.Write("Wprowadź nazwisko pracownika: ");
                            nowyPracownik.Nazwisko = Console.ReadLine() ?? "Nazwisko Pracownika";
                            Console.Write("Wprowadź specjalizację pracownika (Mechanik, Elektryk, Lakiernik, Blacharz, Diagnosta, Menadżer): ");
                            nowyPracownik.SpecjalizacjaPracownika = Specjalizacja.Mechanik;
                            
                            Zaklad.Pracownicy.Add(nowyPracownik);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Dodaj klienta");

                            foreach (var pracownik in Zaklad.Pracownicy)
                            {
                                Console.WriteLine($"Pracownik: {pracownik.Imie} {pracownik.Nazwisko}, Specjalizacja: {pracownik.SpecjalizacjaPracownika}");
                            }

                            Console.ReadKey();
                            break; // Call method to add client
                            // Call method to add client
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Ustawienia");
                            Console.Write("Wprowadź nazwę zakładu: ");
                            Zaklad.Nazwa = Console.ReadLine() ?? "Nazwa Zakładu";
                            Console.Write("Wprowadź adres zakładu: ");
                            Zaklad.Adres = Console.ReadLine() ?? "Adres Zakładu";
                            Console.Write("Wprowadź kontakt do zakładu (adres email/telefon): ");
                            Zaklad.KontaktDoZakladu = Console.ReadLine() ?? "Kontakt Zakładu";

                        Console.ReadKey();
                        break;
              


                        case 4:
                            Console.Clear();
                            Console.WriteLine("Wyświetl ustawienia");
                           
                            Console.WriteLine($"Nazwa zakładu: {Zaklad.Nazwa}");
                            Console.WriteLine($"Adres zakładu: {Zaklad.Adres}");
                            Console.WriteLine($"Kontakt do zakładu: {Zaklad.KontaktDoZakladu}");
                            Console.ReadKey();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Nieprawidłowy wybór. Wybierz opcję 1 lub 2.");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Nieprawidłowy format. Wprowadź liczbę 1 lub 2.");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Wystąpił błąd: {ex.Message}. Naciśnij dowolny klawisz, aby spróbować ponownie.");
                Console.ReadKey();
            }
        }
    }
}