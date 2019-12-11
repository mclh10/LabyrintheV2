using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Salle
    {
        private string nom;
        private Labyrinthe lab;
        private List<Materiel> materielList;

        private static int id_salle = 0;

        public Salle(Labyrinthe myLab)
        {
            this.nom = id_salle.ToString();
            this.lab = myLab;
            this.materielList = null;
            id_salle++;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public Labyrinthe Lab
        {
            get => lab;
            set => lab = value;
        }

        public List<Materiel> MaterielList
        {
            get => materielList;
            set => materielList = value;
        }

        private void DecrireIssues()
        {
            //TODO
        }

        private void DecrireMateriel()
        {
            //TODO
            for (int i = 0; i < this.materielList.Count; i++)
            {
                this.materielList[i].SeDecrire();
            }
        }
        public void MettreMaterielDansSac(Sac mySac) 
        {
            //TODO
            for (int i = 0; i < this.materielList.Count; i++)
            {
                //mySac.Stuff.Add(this.MaterielList.GetRange(i))
            }

        }
        public void SeDecrire()
        {
            //TODO
            Console.WriteLine("Salle - " + this.Nom);
            this.lab.seDecrire();
            this.DecrireMateriel();
            this.DecrireIssues();
        }
        private void ViderMateriel()
        {
            //TODO
            this.materielList.Clear();
        }

    }
}
