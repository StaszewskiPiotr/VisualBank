using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_VisualBank
{
    class Kredyt
    {
        public double kwotaKredytu;
        const int okresKredytowania = 12;
        public const double roczneOprocentowanie = 12;
        public const double miesieczneOprocentowanie = 12 / okresKredytowania;
        public bool czyKredytSplacalny;
        public double[] ratyKredytu = new double[okresKredytowania];
        public double[] odsetkiMsc = new double[okresKredytowania];
        public double[] biezacaWartKredyt = new double[okresKredytowania];

        public Kredyt(double kwotaKredytu, double[] ratyKredytu)
        {
            this.kwotaKredytu = kwotaKredytu;
            this.ratyKredytu = ratyKredytu;
            Wylicz();
        }

        public void Wylicz()
        {
            double biezacaWartoscKredytu = kwotaKredytu;
            double mscStopaOprocentowania = miesieczneOprocentowanie / 100;

            for (int x = 0; x < okresKredytowania; x++)
            {
                double odsetki1 = biezacaWartoscKredytu * mscStopaOprocentowania;
                odsetkiMsc[x] = odsetki1;
                biezacaWartoscKredytu = biezacaWartoscKredytu + odsetki1 - ratyKredytu[x];
                biezacaWartKredyt[x] = biezacaWartoscKredytu;
            }
        }

        public double obliczOdsetki()
        {
            double biezacaWartoscKredytu = kwotaKredytu;
            double mscStopaOprocentowania = miesieczneOprocentowanie / 100;
            double odsetki = 0;

            for (int x = 0; x < okresKredytowania; x++)
            {
                double odsetki1 = biezacaWartoscKredytu * mscStopaOprocentowania;
                odsetkiMsc[x] = odsetki1;
                odsetki += odsetki1;
                biezacaWartoscKredytu = biezacaWartoscKredytu + odsetki1 - ratyKredytu[x];
                biezacaWartKredyt[x] = biezacaWartoscKredytu;
            }
            return Math.Round(odsetki, 2);
        }

        public bool CzyWiększa()
        {
            for (int x = 0; x < biezacaWartKredyt.Length; x++)
            {
                if (biezacaWartKredyt[x] > kwotaKredytu)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Czy3()
        {
            double msc1;
            double msc2;
            double msc3;

            for (int x = 0; x < ratyKredytu.Length - 2; x++)
            {
                msc1 = ratyKredytu[x];
                msc2 = ratyKredytu[x + 1];
                msc3 = ratyKredytu[x + 2];

                if (msc1 == 0 && msc2 == 0 && msc3 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public string czyZdarzenieDefaultowe()
        {
            if (Czy3() == true || CzyWiększa() == true)
            {
                return "tak";
            }
            return "nie";
        }

        public double Przychod()
        {
            double strata = 0;
            if (czyZdarzenieDefaultowe() == "tak")
            {
                strata = -(kwotaKredytu * 0.05);
                return strata;
            }
            return obliczOdsetki();
        }
    }
}
