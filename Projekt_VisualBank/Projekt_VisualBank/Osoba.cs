using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_VisualBank
{
    class Osoba
    {
        public string Imie;
        public string Nazwisko;
        public string dataUrodzenia;
        public string Pesel;

        public Osoba(string Imie, string Nazwisko, string dataUrodzenia, string Pesel)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.Pesel = Pesel;
        }
    }
}
