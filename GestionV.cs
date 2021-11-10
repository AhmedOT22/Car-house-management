using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGrA
{
    class GestionV : IGestionV
    {
        List<Voiture> liste;

        public GestionV()
        {
            liste = new List<Voiture>();
        }

        public void AjouterVoiture(Voiture v)
        {
            liste.Add(v);
        }

        public List<Voiture> ListerVoitures()
        {
            return liste;
        }

        public bool ModifierVoiture(string matricule, Voiture v)
        {
            Voiture x = RechercheVoiture(matricule);
            if (x != null)
            {
                SupprimerVoiture(matricule);
                AjouterVoiture(v);
                return true;
            }
            return false;
        }

        public Voiture RechercheVoiture(string matricule)
        {
            foreach (var item in liste)
            {
                if (matricule == item.Matricule)
                {
                    return item;
                }
            }
            return null;
        }
        public bool SupprimerVoiture(string matricule)
        {
            foreach (var item in liste)
            {
                if (matricule == item.Matricule)
                {
                    liste.Remove(item);
                    return true;
                }
            }
            return false;
        }
    }
}


List<assurance> liste;

public Gestion()
{
    liste = new List<assurance>();
}

public void AjouterAssurance(Assurance a)
{
    liste.Add(a);
}
public Assurance RechercheAssurance(string numéro)
{
    foreach (var item in liste)
    {
        if (numéro == item.numéro)
        {
            return item;
        }
    }
    return null;
}

public List<assuré> ListerConducteur()
{
    List<assuré> listeb;
    if (bon_conducteur == true)
    {
        listeb.Add(a);   
    }
    return listeb;
}

public List<voiture> ListerVoiture()
{
    List<voiture> listev;
    foreach (var item in liste)
    {
        if (nom == item.nom)
        {
          listev.Add(v);
        }
    return listev;
}

public List<assurance> ListerExpiré()
{
    List<assurance> listeaz;
    if (expiré == true)
    {
        listeae.Add(ae);
    }
    return listeae;
}
