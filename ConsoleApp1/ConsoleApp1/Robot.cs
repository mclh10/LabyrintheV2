using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Robot
    {
        private Sac sac;
        private Salle salleCourante; 

        public Sac Sac
        {
            get => sac;
            set => sac = value;
        }

        public void allerVers(int pos)
        {

        }

        private void decrireMateriel()
        {

        }

        public void prendreTout()
        {
            this.sac.;
        }

        public void seDecrire()
        {
            Console.WriteLine("Je suis le Robot et suis dans la salle " + this.salleCourante.Nom);
            sac.seDecrire();
        }
    }
}
