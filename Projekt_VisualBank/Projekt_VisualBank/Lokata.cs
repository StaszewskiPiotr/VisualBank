using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_VisualBank
{
    class Lokata
    {
        public double kwotaWplacona;
        const double oprocentowanieRoczne = 3;
        const double oprocentowanieMiesieczne = oprocentowanieRoczne / 12;
        const int okres = 365;

        public Lokata(double kwotaWplacona)
        {
            this.kwotaWplacona = kwotaWplacona;
        }

        public double Odsetki()
        {
            double odsetki = (kwotaWplacona * okres * (oprocentowanieRoczne / 100)) / 365;
            return odsetki;
        }

        public void setKwotaWplacona(double _kwotaWplacona)
        {
            kwotaWplacona = _kwotaWplacona;
        }

        public double getKwotaWplacona()
        {
            return kwotaWplacona;
        }
    }
}
