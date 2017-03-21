using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_zad2
{

    public interface IBohater
    {
        void BijWroga();
        void SprawdzHp();

    }

    abstract class Bohater : IBohater
    {
        protected int Hp;
        protected int Atak;
        protected Rasa rasa;
        public enum Rasa
        {
            Człowiek,
            Elf,
            Krasnolud,
        }

        public void BijWroga()
        {
            Console.WriteLine("Atak: " + this.Atak);
        }
        public void SprawdzHp()
        {
            Console.WriteLine("Hp: " + this.Hp);
        }
    }

    class Mag : Bohater
    {
        private int mana;

        public Mag(Rasa rasa)
        {
            this.Hp = 2200;
            this.Atak = 350;
            this.mana = 300;
            this.rasa = rasa;
        }

        public void RzucCzar()
        {
            Console.WriteLine("Rzucono czar");
        }
    }

    class Wojownik : Bohater
    {
        public Wojownik(Rasa rasa)
        {
            this.Hp = 3200;
            this.Atak = 500;
            this.rasa = rasa;
        }
        public void RzucToporem()
        {
            Console.WriteLine("Rzucono toporem");
        }
    }

    class Rzezimieszek : Bohater
    {
        private int energia;

        public Rzezimieszek(Rasa rasa)
        {
            this.Hp = 1800;
            this.Atak = 200;
            this.rasa = rasa;
            this.energia = 200;
        }

    }
   
   
    

    class Program
    {
        static void Main(string[] args)
        {
            
        
       
        
    }
   
        
    }
}
