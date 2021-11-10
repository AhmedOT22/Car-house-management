using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGrA
{
    interface IGestionV
    {
        void AjouterVoiture(Voiture v);
        bool SupprimerVoiture(string matricule);
        Voiture RechercheVoiture(string matricule);
        bool ModifierVoiture(string matricule, Voiture v);
        List<Voiture> ListerVoitures();
    }
}
