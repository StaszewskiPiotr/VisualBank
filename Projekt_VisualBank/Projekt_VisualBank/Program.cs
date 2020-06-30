using System;
using System.Collections.Generic;

namespace Projekt_VisualBank
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Klient> listaKlientowZLokata = new List<Klient>();

            Lokata lokata1 = new Lokata(10000);
            Klient klient1 = new Klient("Piotr", "Staszewski", "21-07-1998", "98072306719", lokata1, null);
            listaKlientowZLokata.Add(klient1);

            Lokata lokata2 = new Lokata(13000);
            Klient klient2 = new Klient("Jan", "Kowalski", "21-07-1998", "98072306719", lokata2, null);
            listaKlientowZLokata.Add(klient2);

            Lokata lokata3 = new Lokata(14000);
            Klient klient3 = new Klient("Adam", "Małysz", "21-07-1998", "98072306719", lokata3, null);
            listaKlientowZLokata.Add(klient3);

            Lokata lokata4 = new Lokata(1000);
            Klient klient4 = new Klient("Korwin", "Mikke", "21-07-1998", "98072306719", lokata4, null);
            listaKlientowZLokata.Add(klient4);

            Lokata lokata5 = new Lokata(16000);
            Klient klient5 = new Klient("Monika", "Bielejec", "21-07-1998", "98072306719", lokata5, null);
            listaKlientowZLokata.Add(klient5);

            Lokata lokata6 = new Lokata(7000);
            Klient klient6 = new Klient("Gosia", "Włodarczyk", "21-07-1998", "98072306719", lokata6, null);
            listaKlientowZLokata.Add(klient6);

            Lokata lokata7 = new Lokata(12400);
            Klient klient7 = new Klient("Anna", "Olesińska", "21-07-1998", "98072306719", lokata7, null);
            listaKlientowZLokata.Add(klient7);

            Lokata lokata8 = new Lokata(120000);
            Klient klient8 = new Klient("Marian", "Banan", "21-07-1998", "98072306719", lokata8, null);
            listaKlientowZLokata.Add(klient8);

            Lokata lokata9 = new Lokata(2000);
            Klient klient9 = new Klient("Krzysztof", "Kot", "21-07-1998", "98072306719", lokata9, null);
            listaKlientowZLokata.Add(klient9);

            Lokata lokata10 = new Lokata(3000);
            Klient klient10 = new Klient("Paulina", "Mikuła", "21-07-1998", "98072306719", lokata10, null);
            listaKlientowZLokata.Add(klient10);

            Lokata lokata11 = new Lokata(6000);
            Klient klient11 = new Klient("Zuzanna", "Kowalczyk", "21-07-1998", "98072306719", lokata11, null);
            listaKlientowZLokata.Add(klient11);

            Lokata lokata12 = new Lokata(8000);
            Klient klient12 = new Klient("Mateusz", "Bareja", "21-07-1998", "98072306719", lokata12, null);
            listaKlientowZLokata.Add(klient12);

            Lokata lokata13 = new Lokata(19000);
            Klient klient13 = new Klient("Aleksandra", "Staszewska", "21-07-1998", "98072306719", lokata13, null);
            listaKlientowZLokata.Add(klient4);

            Lokata lokata14 = new Lokata(12000);
            Klient klient14 = new Klient("Julia", "Rybak", "21-07-1998", "98072306719", lokata14, null);
            listaKlientowZLokata.Add(klient14);

            Lokata lokata15 = new Lokata(15500);
            Klient klient15 = new Klient("Kamila", "Kruschewska", "21-07-1998", "98072306719", lokata15, null);
            listaKlientowZLokata.Add(klient15);

            List<Klient> listaKlientowZKredytem = new List<Klient>();
            
            double[] raty1 = { 888.49, 888.49, 888.49, 888.49, 888.49, 888.49, 888.49, 888.49, 888.49, 888.49, 888.49, 888.49 };
            Kredyt kredyt1 = new Kredyt(10000, raty1);
            Klient klient16 = new Klient("Michał", "Grzywaczewski", "21-07-1998", "98072306719", null, kredyt1);
            listaKlientowZKredytem.Add(klient16);
            
            double[] raty2 = { 1066.19, 1066.19, 1066.19, 1066.19, 1066.19, 1066.19, 1066.19, 1066.19, 1066.19, 1066.19, 1066.19, 1066.19 };
            Kredyt kredyt2 = new Kredyt(12000, raty2);
            Klient klient17 = new Klient("Gabrysia", "Kowalska", "21-07-1998", "98072306719", null, kredyt2);
            listaKlientowZKredytem.Add(klient17);
            
            double[] raty3 = { 4442.44, 4442.44, 4442.44, 4442.44, 4442.44, 4442.44, 4442.44, 4442.44, 4442.44, 4442.44, 4442.44, 4442.44 };
            Kredyt kredyt3 = new Kredyt(50000, raty3);
            Klient klient18 = new Klient("Angelika", "Rybak", "21-07-1998", "98072306719", null, kredyt3);
            listaKlientowZKredytem.Add(klient18);

            double[] raty4 = { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };
            Kredyt kredyt4 = new Kredyt(12000, raty4);
            Klient klient19 = new Klient("Piotr", "Motłoch", "21-07-1998", "98072306719", null, kredyt4);
            listaKlientowZKredytem.Add(klient19);

            double[] raty5 = { 6219.42, 6219.42, 6219.42, 6219.42, 6219.42, 6219.42, 6219.42, 6219.42, 6219.42, 6219.42, 6219.42, 6219.42 };
            Kredyt kredyt5 = new Kredyt(70000, raty5);
            Klient klient20 = new Klient("Marek", "Siudym", "21-07-1998", "98072306719", null, kredyt5);
            listaKlientowZKredytem.Add(klient20);

            double[] raty6 = { 8884.88, 8884.88, 8884.88, 8884.88, 8884.88, 8884.88, 8884.88, 8884.88, 8884.88, 8884.88, 8884.88, 8884.88 };
            Kredyt kredyt6 = new Kredyt(100000, raty6);
            Klient klient21 = new Klient("Bartek", "Srartek", "21-07-1998", "98072306719", null, kredyt6);
            listaKlientowZKredytem.Add(klient21);

            double[] raty7 = { 10661.85, 10661.85, 10661.85, 10661.85, 10661.85, 10661.85, 10661.85, 10661.85, 10661.85, 10661.85, 10661.85, 10661.85 };
            Kredyt kredyt7 = new Kredyt(120000, raty7);
            Klient klient22 = new Klient("Piotr", "Staszewski", "21-07-1998", "98072306719", null, kredyt7);
            listaKlientowZKredytem.Add(klient22);

            double[] raty8 = { 1599.28, 1599.28, 1599.28, 1599.28, 1599.28, 1599.28, 1599.28, 1599.28, 1599.28, 1599.28, 1599.28, 1599.28 };
            Kredyt kredyt8 = new Kredyt(18000, raty8);
            Klient klient23 = new Klient("Piotr", "Staszewski", "21-07-1998", "98072306719", null, kredyt8);
            listaKlientowZKredytem.Add(klient23);

            double[] raty9 = { 500, 1000, 0, 0, 0, 300, 500, 450, 700, 300, 444.24, 444.24 };
            Kredyt kredyt9 = new Kredyt(5000, raty9);
            Klient klient24 = new Klient("Piotr", "Staszewski", "21-07-1998", "98072306719", null, kredyt9);
            listaKlientowZKredytem.Add(klient24);

            double[] raty10 = { 799.64, 799.64, 799.64, 799.64, 799.64, 799.64, 799.64, 799.64, 799.64, 799.64, 799.64, 799.64 };
            Kredyt kredyt10 = new Kredyt(9000, raty10);
            Klient klient25 = new Klient("Piotr", "Staszewski", "21-07-1998", "98072306719", null, kredyt10);
            listaKlientowZKredytem.Add(klient25);
            

            Bank VisualBank = new Bank(listaKlientowZLokata, listaKlientowZKredytem);
            Console.WriteLine(VisualBank.toString());
            Console.WriteLine("Zysk BRUTTO banku wynosi: " + VisualBank.ZyskBrutto());
            Console.WriteLine("Zysk NETTO banku wynosi: " + VisualBank.ZyskNetto());
            Console.WriteLine("Pieniądze, które uzyskał bank z kredytów od innych banków: " + VisualBank.pozyczPieniadze());
            Console.ReadKey();
        }
        
    }
}
