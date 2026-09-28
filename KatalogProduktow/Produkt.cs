using System;

namespace KatalogProduktow
{
    internal class Produkt
    {
        private string _nazwa;
        public string Nazwa
        
        {
            get { return _nazwa; }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Nazwa nie może być pusta.");
                }
                _nazwa = value;
            }
        }

        private double _Cena;
        public double Cena
        {
            get { return _Cena; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cena nie może być ujemna.");
                }
                _Cena = value;
            }
        }

        public string Kategoria;
        public double Ilosc;

        public double WartoscMagazynu
        {
            get { return _Cena * Ilosc; }
        }
    }
}

