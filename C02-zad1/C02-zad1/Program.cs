using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    interface ISamochod
    {
        void WypiszMarke();
        void WypiszSalon();
    }
    class AstonMartin : ISamochod
    {
        private string Marka;
        private string Salon;

        public AstonMartin(string Marka, string Salon)
        {
            this.Marka = Marka;
            this.Salon = Salon;
        }

        public void WypiszMarke()
        {
            Console.Write("Samochod marki " + this.Marka);
        }

        public void WypiszSalon()
        {
            Console.WriteLine(" z salonu " + this.Salon);

        }
    }
    class RangeRover : ISamochod
    {
        private string Marka;
        private string Salon;

        public RangeRover(string Marka, string Salon)
        {
            this.Marka = Marka;
            this.Salon = Salon;
        }

        public void WypiszMarke()
        {
            Console.Write("Samochod marki " + this.Marka);
        }

        public void WypiszSalon()
        {
            Console.WriteLine(" z salonu " + this.Salon);

        }

    }
    class RollsRoyce : ISamochod
    {
        private string Marka;
        private string Salon;

        public RollsRoyce(string Marka, string Salon)
        {
            this.Marka = Marka;
            this.Salon = Salon;
        }

        public void WypiszMarke()
        {
            Console.Write("Samochod marki " + this.Marka);
        }

        public void WypiszSalon()
        {
            Console.WriteLine(" z salonu " + this.Salon);

        }

        static void Main(string[] args)
        {
            AstonMartin ford = new AstonMartin("Aston Martin DB9", "Siekierski");
            ford.WypiszMarke();
            ford.WypiszSalon();

            RangeRover opel = new RangeRover("Range Rover Evoque", "Pawłowski");
            opel.WypiszMarke();
            opel.WypiszSalon();

            RollsRoyce polonez = new RollsRoyce("Rolls Royce Phantom", "Q&Q");
            polonez.WypiszMarke();
            polonez.WypiszSalon();
        }
    }
}