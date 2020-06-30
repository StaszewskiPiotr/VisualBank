using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_VisualBank
{
    class Klient : Osoba
    {
        Lokata lokata;
        Kredyt kredyt;
        public Klient(string Imie, string Nazwisko, string dataUrodzenia, string Pesel, Lokata lokata, Kredyt kredyt)
            : base(Imie, Nazwisko, dataUrodzenia, Pesel)
        {
            this.lokata = lokata;
            this.kredyt = kredyt;
        }

        public void setImie(string _Imie)
        {
            Imie = _Imie;
        }

        public string getImie()
        {
            return Imie;
        }

        public void setNazwisko(string _Nazwisko)
        {
            Nazwisko = _Nazwisko;
        }

        public string getNazwisko()
        {
            return Nazwisko;
        }

        public void setDataUrodzenia(string _DataUrodzenia)
        {
            dataUrodzenia = _DataUrodzenia;
        }

        public string getDataUrodzenia()
        {
            return dataUrodzenia;
        }

        public void setPesel(string _Pesel)
        {
            Pesel = _Pesel;
        }

        public string getPesel()
        {
            return Pesel;
        }

        public void setLokata(Lokata _lokata)
        {
            lokata = _lokata;
        }

        public Lokata getLokata()
        {
            return lokata;
        }

        public void setKredyt(Kredyt _kredyt)
        {
            kredyt = _kredyt;
        }

        public Kredyt getKredyt()
        {
            return kredyt;
        }
    }
}
