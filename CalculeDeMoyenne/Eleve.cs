using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeDeMoyenne
{
    public class Eleve
    {
        private string _nom;
        private string _prenom;
        private List<Matiere> _matieres;

        public Eleve(string nom, string prenom)
        {
            _nom = nom;
            _prenom = prenom;
            _matieres = new List<Matiere>();
        }

        public void AjouterMatiere(string unNom, string uneDescription = "")
        {
            _matieres.Add(new Matiere(unNom, uneDescription));
        }
    }
}
