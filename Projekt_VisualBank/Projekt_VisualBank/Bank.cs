using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projekt_VisualBank
{
    class Bank
    {
        List<Klient> listaKlientowZLokata = new List<Klient>();
        List<Klient> listaKlientowZKredytem = new List<Klient>();

        public Bank(List<Klient> listaKlientowZLokata, List<Klient> listaKlientowZKredytem)
        {
            this.listaKlientowZLokata = listaKlientowZLokata;
            this.listaKlientowZKredytem = listaKlientowZKredytem;
        }

        public double ZyskBrutto()
        {
            double odsetkiKredytow = 0;
            double odsetkiLokat = 0;

            double zyskBrutto = 0;

            for (int x = 0; x < listaKlientowZKredytem.Count; x++)
            {
                odsetkiKredytow += listaKlientowZKredytem[x].getKredyt().Przychod();
            }

            for (int x = 0; x < listaKlientowZLokata.Count; x++)
            {
                odsetkiLokat += listaKlientowZLokata[x].getLokata().Odsetki();
            }

            zyskBrutto = odsetkiKredytow - odsetkiLokat;

            return Math.Round(zyskBrutto,2);
        }

        public double ZyskNetto()
        {
            double zyskBrutto = ZyskBrutto();
            double zyskNetto = 0;

            if (zyskBrutto > 0)
            {
                zyskNetto = zyskBrutto - (zyskBrutto * 0.19);
            }
            else
            {
                zyskNetto = zyskBrutto;
            }
            return Math.Round(zyskNetto,2);
        }

        public double pozyczPieniadze()
        {
            double pieniadzePozaLokatami = 0;
            List<double> listaKredytow = new List<double>();
            StreamReader sr = new StreamReader("kwotyKredytow.txt");
            Random los = new Random();
            double random;
            string s;
            double d;
            do
            {
                s = sr.ReadLine();
                d = Convert.ToDouble(s);
                listaKredytow.Add(d);
            } while (s != null);
            sr.Close();
            listaKredytow.RemoveAt(listaKredytow.Count - 1);

            for(int x = 0;x < listaKredytow.Count; x++)
            {
                random = los.NextDouble() * (2 - 1.5) + 1.5;
                pieniadzePozaLokatami += listaKredytow[x] - (listaKredytow[x] * (random / 100));
            }
            return Math.Round(pieniadzePozaLokatami,2);
        }

        public string toString()
        {
            Console.WriteLine("KLIENCI Z LOKATĄ");
            for (int x = 0; x < listaKlientowZLokata.Count; x++)
            {
                Console.WriteLine("imię: " + listaKlientowZLokata[x].getImie() + ", nazwisko: " + listaKlientowZLokata[x].getNazwisko() + ", data urodzenia: " + listaKlientowZLokata[x].getDataUrodzenia() + ", PESEL: " + listaKlientowZLokata[x].getPesel() + " || Lokata: kwota - " + listaKlientowZLokata[x].getLokata().getKwotaWplacona() + ", odsetki: " + listaKlientowZLokata[x].getLokata().Odsetki());
            }
            Console.WriteLine();
            Console.WriteLine("KLIENCI Z KREDYTEM");
            for (int x = 0; x < listaKlientowZKredytem.Count; x++)
            {
                Console.WriteLine("imię: " + listaKlientowZKredytem[x].getImie() + ", nazwisko: " + listaKlientowZKredytem[x].getNazwisko() + ", data urodzenia: " + listaKlientowZKredytem[x].getDataUrodzenia() + ", PESEL: " + listaKlientowZKredytem[x].getPesel() + " || Kredyt: kwota - " + listaKlientowZKredytem[x].getKredyt().kwotaKredytu + ", przychód dla banku: " + listaKlientowZKredytem[x].getKredyt().Przychod() + ", czy zaszło zdarzenie defaultowe: " + listaKlientowZKredytem[x].getKredyt().czyZdarzenieDefaultowe());
            }
            Console.WriteLine();
            return null;
        }
    }
}
