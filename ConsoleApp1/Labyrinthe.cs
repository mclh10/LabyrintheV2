using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Labyrinthe
    {
        private Robot rob;
        private int nbSalles;
        private List<Salle> listeSalles;

        public Labyrinthe(int myNbSalles)
        {
            this.rob = new Robot();
            this.nbSalles = myNbSalles;
            this.listeSalles = new List<Salle>();
        }
  
        public Robot Rob
        {
            get => rob;
            set => rob = value;
        }

        public List<Salle> ListeSalles
        {
            get => listeSalles;
            set => listeSalles = value;
        }

        public void seDecrire()
        {

        }

    }
}
