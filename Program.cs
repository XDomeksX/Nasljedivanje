using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje
{
    class Cat
    {
        bool opasna;
        public bool Opasna { get => opasna; set => opasna = value; }
        public virtual void Opasnost()  //virtual služi za override, ali samo za nas u ovom slucaju inace i za dr. stvari
        {
            Opasna = false;
        }
    }

    class Gepard : Cat
    {
        public override void Opasnost()
        {
            Opasna = true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat maca = new Cat();
            maca.Opasnost();
            Console.WriteLine("Maca opasnost? " + maca.Opasna);

            Gepard gepard = new Gepard();
            gepard.Opasnost();
            Console.WriteLine("Gepard opasan? " + gepard.Opasna);

            Console.ReadKey();
        }
    }
}
