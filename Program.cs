using System;


class Program
{
    static void Main(string[] args)
    {
        UpravljanjePopisom upravljanje = new UpravljanjePopisom();

        while (true)
        {
            Console.WriteLine("\nOdaberite opciju:");
            Console.WriteLine("D - Dodaj klijenta");
            Console.WriteLine("O - Obrisi klijenta");
            Console.WriteLine("I - Ispisi sve klijente");
            Console.WriteLine("X - Izlaz");

            string izbor = Console.ReadLine();

            switch (izbor)
            {
                case "D":
                    Console.Write("Unesite ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Unesite ime: ");
                    string ime = Console.ReadLine();
                    Console.Write("Unesite prezime: ");
                    string prezime = Console.ReadLine();
                    Console.Write("Unesite kontakt: ");
                    string kontakt = Console.ReadLine();

                    upravljanje.DodajKlijenta(new Klijent(id, ime, prezime, kontakt));
                    break;

                case "O":
                    Console.Write("Unesite ID klijenta za brisanje: ");
                    int idZaBrisanje = int.Parse(Console.ReadLine());
                    upravljanje.ObrisiKlijenta(idZaBrisanje);
                    break;

                case "I":
                    upravljanje.IspisiSveKlijente();
                    break;

                case "X":
                    Console.WriteLine("Izlaz iz programa.");
                    return;

                default:
                    Console.WriteLine("Nevažeća opcija, pokušajte ponovno.");
                    break;
            }
        }
    }
}
