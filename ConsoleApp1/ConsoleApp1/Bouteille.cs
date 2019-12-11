using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bouteille:Materiel
    {
        private int volume;

        public int Volume
        {
            get => volume;
            set => volume = value;
        }

        public void seDecrire()
        {
            Console.WriteLine("Je suis une bouteille de volume " + this.Volume);
        }
    }
}
