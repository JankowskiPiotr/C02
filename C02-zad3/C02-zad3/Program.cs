using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_zad3
{   
    abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public Osoba(string imie, string nazwisko, string dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Imie: " + this.imie + ", Nazwisko: " + this.nazwisko + ", Data urodzenia: " + this.dataUrodzenia);
        }
    }

    class Student : Osoba
    {
        private int rok;
        private int nrIndeksu;
        private int grupa;

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrIndeksu) : base(imie, nazwisko, dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.rok = rok;
            this.nrIndeksu = nrIndeksu;
            this.grupa = grupa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Imie: " + this.imie + ", Nazwisko: " + this.nazwisko + ", Data urodzenia: " + this.dataUrodzenia + ", Rok: " +this.rok+" , Grupa: "+ this.grupa +" , nr.Indeksu: " + this.nrIndeksu );
        }
        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc) { }
        public void WypiszOceny(string nazwaPrzedmiotu) { }
        public void WypiszOceny() { }
        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc) { }
        public void UsunOceny() { }
        public void UsunOceny(string nazwaPrzedmiotu) { }

    }

    class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Pilkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
            : base(imie, nazwisko, dataUrodzenia)
        {
            this.pozycja = pozycja;
            this.klub = klub;

        }
        public void WypiszInfo()
        {
            Console.WriteLine("Imie: " + this.imie + ", Nazwisko: " + this.nazwisko + ", Data urodzenia: " + this.dataUrodzenia + ", Pozycja: " + this.pozycja + ", Klub: " + this.klub);
        }
        public void StrzelGola()
        {
            liczbaGoli++;
            Console.WriteLine("Strzelono gola");
        }
    }

    class PilkarzReczny : Pilkarz
    {
        public PilkarzReczny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
            : base(imie, nazwisko, dataUrodzenia, pozycja, klub)
        {
            
        }

        public void StrzelGola()
        {
            Console.WriteLine("Piłkarz ręczny strzelił gola");
        }
    }

    class PilkarzNozny : Pilkarz
    {
        public PilkarzNozny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
            : base(imie, nazwisko, dataUrodzenia, pozycja, klub)
        {

        }
        public void StrzelGola()
        {
            Console.WriteLine("Piłkarz nożny strzelił gola");
        }
    }
    class Ocena
    {
        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

        public Ocena(string nazwaPrzedmiotu, string data, double wartosc)
        {
            this.nazwaPrzedmiotu = nazwaPrzedmiotu;
            this.data = data;
            this.wartosc = wartosc;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Przedmiot: " + this.nazwaPrzedmiotu + ", Data: " + this.data + ", Wartosc: " + this.wartosc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
