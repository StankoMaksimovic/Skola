using System;

namespace Skola
{
    class Program
    {
        static void Main(string[] args)
        {
            var Stanko = new Ucenici();
            Stanko.ime_Ucenika = "Stanko";
            Stanko.prezime_Ucenika = "Maksimovic";
            Stanko.ime_Jednog_Roditelja = "Momcilo";
            Stanko.PrintUcenika();

            var PrviRazred = new Predmeti();
            PrviRazred.Biologija = 5;
            PrviRazred.Engleski = 4;
            PrviRazred.Fizicko = 4;
            PrviRazred.Hemija = 2;
            PrviRazred.Matematika = 2;
            PrviRazred.Srpski = 5;
            PrviRazred.Fizika = 3;
            PrviRazred.prosekOcena();
           
        }
    }
}
