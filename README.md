# VisualBank---csharp

CASE ZALICZENIOWY Z WARSZTATU PODSTAWY PROGRAMOWANIA W C#

Banki komercyjne działają tradycyjnie na podstawie pieniężnego obrotu depozytowo-kredytowego. Depozytariusze wpłacają środki na rachunki bieżące (ROR) i w postaci lokat terminowych. Środki te są następnie pożyczane w postaci kredytów (konsumpcyjnych, inwestycyjnych, hipotecznych) lub pożyczek kredytobiorcom. Bank, by osiągać zysk, ustala oprocentowanie lokat na niższym poziomie, niż oprocentowanie kredytów. 

Zadaniem zaliczeniowym jest stworzenie symulacji banku komercyjnego działającego w taki właśnie sposób. Zadanie składa się z części obowiązkowej (punktowanej na 25 pkt., wystarczające u większości, by zaliczyć) oraz części dodatkowej, której punktacja została określona niżej. 

	Część obowiązkowa – symulacja (25 pkt):

VisualBank SA jest bankiem komercyjnym działającym na podstawie stosownych regulacji sektora finansowego w Polsce od 2015 roku i zajmuje się tradycyjną działalnością depozytowo-kredytową. Zarząd banku zdecydował na samym początku działalności, że nie będzie zajmował się tzw. bankowością inwestycyjną (czyli inwestowaniem w instrumenty giełdowe, w tym w imieniu klientów), od czego powołał osobną spółkę-córkę będącą Towarzystwem Funduszy Inwestycyjnych.  

	Lokaty
Lokaty w banku są przechowywane na okres 12 miesięcy. Ich oprocentowanie jest liczone tzw. procentem prostym, czyli co miesiąc na koncie depozytariusza przybywa określona z góry wielkość odsetek, liczona od podstawy będącej wysokością sumy lokaty wpłaconej na samym początku.

np. Załóżmy, że Pan X wpłacił do banku na lokatę 10 000 zł, oprocentowanie miesięczne netto wynosi 0,1%.
	Odsetki w styczniu: 10 000 * 0,001 = 10 zł
	Odsetki w lutym: 10 000 * 0,001 = 10 zł
	Odsetki w marcu: 10 000 * 0,001 = 10 zł
……
	Odsetki w grudniu: 10 000* 0,001 = 10 zł.

Kwota lokaty po 12 miesiącach wyniesie 10 000 + 12 * 10 = 10 120 zł. 

	Kredyty

VisualBank nie rozróżnia celów kredytów (na potrzeby symulacji przyjmujemy, że dokładnie tak samo traktowane są kredyty konsumpcyjne, inwestycyjne i hipoteczne). Okres kredytowania w przypadku każdego kredytu jest taki sam i wynosi tyle samo co okres lokaty – 12 miesięcy. 

Spłata kredytu odbywa się zgodnie z następującym schematem: 

I_t=〖PV〗_(t-1)*r

〖PV〗_(t )=〖PV〗_(t-1 )+ I_t- R_t

Gdzie 〖PV〗_(t )oznacza bieżącą wartość kredytu w okresie t, 〖PV〗_(t-1 ) - w okresie t-1 (poprzednim), R_t oznacza ratę, jaką wpłacił kredytobiorca w okresie t, I_t oznacza odsetki od kredytu w okresie t, a r jest miesięczną stopą oprocentowania kredytu. 

Np. Załóżmy, że Pani Y ma do spłacenia kredyt w wysokości 10 000 zł oprocentowany na 9% rocznie tj. 9/12 = 0,75% miesięcznie. W styczniu opłaciła ratę w wysokości 700 zł, w lutym w wysokości 1000 zł, natomiast w marcu nie mogła wpłacić nic w związku z chwilową utratą płynności finansowej.

	Odsetki w styczniu: I_1= 〖PV〗_0* 0,0075  = 10 000 * 0,0075  = 75 zł
Kwota bieżąca kredytu: 〖PV〗_1= 〖PV〗_0+ I_1-R_1 = 10 000 + 75 – 700 = 9 375 

	Odsetki w lutym:  I_2= 〖PV〗_1* 0,0075  = 9 375 * 0,0075 =~ 70,3 zł
Kwota bieżąca kredytu: 〖PV〗_2= 〖PV〗_1+ I_2-R_2 = 9 375 + 70,3 – 1000 =   
= 8445,3 zł.
	Odsetki w marcu: I_3= 〖PV〗_2* 0,0075 = 8445,3 * 0,0075 = 63,3 zł
Kwota bieżąca kredytu:  〖PV〗_3= 〖PV〗_2+ I_3-R_3 = 8445,3 + 63,3 – 0 = 8508,3 zł. 

Jak widzimy po ostatniej iteracji z marca, kwota bieżąca kredytu może w szczególnym przypadku się zwiększać (jeśli odsetki w danym miesiącu przewyższą ratę). Banki muszą brać pod uwagę ryzyko tzw. zdarzenia defaultowego, czyli sytuacji, w której kredytobiorca nie będzie w stanie dalej spłacać kredytu. VisualBank bierze pod uwagę następujące kryteria klasyfikacji kredytu jako niespłacalny:
	Bieżąca kwota kredytu (〖PV〗_(t )) w danym miesiącu przewyższy kwotę kredytu na samym początku (〖PV〗_0),

lub

	Spłacana rata w trzech następnych po sobie miesiącach będzie równa 0.

W takim przypadku VisualBank przewiduje procedurę sądową i ściąganie wierzytelności przez firmę windykacyjną lub komornika, w wyniku czego otrzyma 95% początkowej kwoty kredytu. 

Zadanie polega na stworzeniu metod, które policzą zysk netto VisualBanku na podstawie 15 zmiennych zawierających kwotę lokaty i 10 tablic kredytobiorców po 12 pozycji każda (raty spłacane w każdym miesiącu kredytowania) oraz 10 zmiennych oznaczających odpowiednie kwoty kredytu. Część dotycząca zysku nie musi być robiona osobnymi metodami, może być liczona w Main pomocniczymi, wcześniej stworzonymi metodami. Częścią zadania jest przetestowanie działania programu właśnie na podstawie przykładowych tablic. 
Zysk brutto to suma odsetek od kredytów pomniejszona o sumę odsetek od lokat i sumę strat związanych ze zdarzeniami defaultowymi. Opodatkowanie zysku to 19% od zysku brutto, a zysk netto to zysk brutto pomniejszony o podatek. W przypadku straty oprocentowanie oczywiście wynosi 0%.

Założenia case’a w części obowiązkowej: 
	Oprocentowanie roczne lokaty – 3%, roczne kredytu – 12%.
	Pomijamy środki w banku wpłacane na rachunkach bieżących (ROR).
	Pomijamy stopę rezerw obowiązkowych, wpłaty na Bankowy Fundusz Gwarancyjny i inne rezerwy, które prawdziwe banki muszą spełniać. 
	Pomijamy kwestie podatkowe związane z tzw. podatkiem Belki (podatek od zysków kapitałowych).
	Pomijamy dokapitalizowanie banku związane z obrotem międzybankowym (natomiast w części dodatkowej będzie wykorzystane). 

Wskazówki:
	Stwórz metody: static double Odsetki (double[] tab, double KwotaK, double r), która pobiera tablicę rat kredytowych, kwotę kredytu i stopę oprocentowania r i policz w pętli odsetki od kredytu. Stwórz pomocnicze metody static bool CzyWiększa(double[] tab, double KwotaK, double r), która sprawdza, czy bieżąca kwota w danym miesiącu nie przewyższy początkowej i metodę static bool Czy3 (double[] tab), która sprawdza, czy w tablicy nie ma po sobie trzech zer. Następnie wykorzystaj je w metodzie static double Przychód (double[] tab, double KwotaK, double r), która ostatecznie oblicza jaki przychód przyniósł dany klient (w szczególności ujemny, jeśli jest to default). 
	Przychody i koszty banku (odsetki od lokat) oraz zyski najłatwiej liczyć wywołując metody w Main.

	Część dodatkowa – dokapitalizowywanie banku (15 pkt.)
Banki komercyjne mogą pozyskiwać kapitał potrzebny do udzielania kredytów nie tylko z lokat. Istnieje obrót międzybankowy, w którym banki komercyjne pożyczają sobie nawzajem fundusze na określony procent. 
W zależności od kondycji polskiej gospodarki, Bank Centralny (w Polsce – Narodowy Bank Polski) ustala stopy procentowe, na podstawie których liczony jest WIBOR (Warsaw Interbank Offering Rate), stopa po której banki komercyjne pożyczają sobie pieniądze. Przyjmij, że WIBOR waha się od 1,5 do 2%, a jego wartość jest ustalana na podstawie kodu:

Random los = new Random(); //klasa Random obsługuje liczby losowe
los.NextDouble(); //zwraca liczbę typu double z przedziału (0;1)

Zadanie dodatkowe polega na tym, by wczytać z pliku 10 liczb będących kwotami kredytu z innych banków, ustalić dla każdej kwoty oprocentowanie klasą Random i obliczyć kwotę, jaką będzie mógł dysponować bank dodatkowo poza lokatami. Kwoty te nie powiększają ani nie pomniejszają w żaden sposób zysku netto banku.
