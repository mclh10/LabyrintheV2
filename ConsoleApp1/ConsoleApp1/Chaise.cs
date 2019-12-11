using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Chaise : Materiel
    {
        private int couleur;
        private int nbPieds;

        public int Couleur
        {
            get => couleur;
            set => couleur = value;
        }

        public int NbPieds
        {
            get => nbPieds;
            set => nbPieds = value;
        }

        public override void SeDecrire()
        {
            Console.WriteLine("Je suis une chaise de couleur " + this.); 
        }
    }
}
