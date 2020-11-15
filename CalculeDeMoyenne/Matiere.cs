using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeDeMoyenne
{
    public class Matiere
    {
        private string _nom;
        private string _description;
        private List<Note> _notes;

        public Matiere(string unNom, string uneDescription)
        {
            _nom = unNom;
            _description = uneDescription;
            _notes = new List<Note>();
        }

        public void AjouterNote(double uneNote, DateTime uneDate, float unCoef = 1, string unLibelle = "")
        {
            _notes.Add(new Note(uneNote, unCoef, unLibelle, uneDate));
        }

        public double CalculerMoyenne()
        {
            double sommeDesNotes = 0;
            foreach (Note note in _notes)
            {
                sommeDesNotes += note.GetNote();
            }
            return sommeDesNotes / _notes.Count;
        }
    }
}
