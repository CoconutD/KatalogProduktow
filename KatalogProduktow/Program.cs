using System.Diagnostics;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] nazwy = { "Procesor", "Pamięć RAM", "Dysk SSD", "Zasilacz", "Karta graficzna" };
double[] ceny = { 899.00, 249.50, 379.00, 189.99, 599.99 };
﻿Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] nazwy = { "Procesor", "Pamięć RAM", "Dysk SSD", "Zasilacz",};
double[] ceny = { 899.00, 249.50, 379.00, 189.99 };

double suma = 0;
int licznik = 0;

for (int i = 0; i < nazwy.Length; i++)
{
    // Do sumy trafiają tylko produkty droższe niż 400 zł
    if (ceny[i] > 400) // przechodzi 899 dlatego ze ona więksa niz 400
    {
        suma = suma + ceny[i]; // ceny dodawają sie do zmiennej suma 
        licznik++; // dodaje +1 do licznika
    }
}
double srednia = suma / licznik;
if (srednia == 0) Debugger.Break();
Console.WriteLine($"ilosc produktów: {licznik}");
Console.WriteLine($"Średnia cena: {srednia:C} z {licznik} produktów");