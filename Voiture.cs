using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGrA
{
    enum TypeCarburant { Diesel, Essence, Hybride, Electrique}
    enum Accessoires { Climatisation, FermetureCentralisée, CaméraRecul}
    class Voiture
    {
        string matricule;
        string marque;
        string modele;
        DateTime dateMC;
        double prix;
        TypeCarburant carburant;
        List<Accessoires> details;

        public string Matricule { get => matricule; set => matricule = value; }
        public string Marque { get => marque; set => marque = value; }
        public string Modele { get => modele; set => modele = value; }
        public DateTime DateMC { get => dateMC; set => dateMC = value; }
        public double Prix { get => prix; set => prix = value; }
        internal TypeCarburant Carburant { get => carburant; set => carburant = value; }
        internal List<Accessoires> Details { get => details; set => details = value; }

        public Voiture()
        {
            matricule = "0000-A-00";
            marque = "????????";
            modele = "???????";
            dateMC = DateTime.Now;
            prix = 0;
            carburant = TypeCarburant.Diesel;
            details = new List<Accessoires>();
        }
        public override string ToString()
        {
            string s = matricule + " " + marque + " " + modele + " " + dateMC + " " 
                + prix+" "+carburant;
            foreach (var item in details)
            {
                s += " " + item;
            }
            return  s;
        }
    }
}
