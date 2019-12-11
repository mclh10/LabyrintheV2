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
        }
        public void MettreMaterielDansSac(Sac mySac) 
        {
            //TODO
        }
        public void SeDecrire()
        {
            //TODO
            for (int i = 0; i < this.materielList.Count; i++)
            {
                this.materielList[i].SeDecrire();
            }
        }
        private void ViderMateriel()
        {
            //TODO
        }

    }
}
