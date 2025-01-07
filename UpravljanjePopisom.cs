using System;
using System.Collections.Generic;

public class UpravljanjePopisom : IUpravljanjePopisom
{
    private List<Klijent> klijenti = new List<Klijent>();

    public void DodajKlijenta(Klijent klijent)
    {
        klijenti.Add(klijent);
        Console.WriteLine("Klijent uspješno dodan.");
    }

    public void ObrisiKlijenta(int id)
    {
        Klijent klijentZaBrisanje = klijenti.Find(k => k.ID == id);
        if (klijentZaBrisanje != null)
        {
            klijenti.Remove(klijentZaBrisanje);
            Console.WriteLine("Klijent uspješno obrisan.");
        }
        else
        {
            Console.WriteLine("Klijent s navedenim ID-om nije pronađen.");
        }
    }

    public void IspisiSveKlijente()
    {
        if (klijenti.Count == 0)
        {
            Console.WriteLine("Nema klijenata u popisu.");
        }
        else
        {
            Console.WriteLine("Popis svih klijenata:");
            foreach (var klijent in klijenti)
            {
                Console.WriteLine(klijent);
            }
        }
    }
}
