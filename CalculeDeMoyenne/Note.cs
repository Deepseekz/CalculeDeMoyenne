using System;

namespace CalculeDeMoyenne
{
    internal class Note
    {
        private double _note;
        private float _coef;
        private string _libelle;
        private DateTime _date;

        public Note(double uneNote, float unCoef, string unLibelle, DateTime uneDate)
        {
            _note = uneNote;
            _coef = unCoef;
            _libelle = unLibelle;
            _date = uneDate;
        }

        public double GetNote()
        {
            return _note;
        }

        public void SetNote(double value)
        {
            _note = value;
        }
    }
}