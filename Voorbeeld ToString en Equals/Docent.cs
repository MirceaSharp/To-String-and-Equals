using System;

namespace Voorbeeld_ToString_en_Equals
{
    class Docent : Gebruiker
    {
        private double _loon;

        public Docent(char type, int nummer, string voornaam, string familienaam, double loon)
            : base(type, nummer, voornaam, familienaam)
        {
            this.Loon = loon;
        }

        public double Loon
        {
            get { return _loon; }
            set { _loon = value; }
        }

        public override string ToonAlles(string seperator)
        {
            return base.ToonAlles(seperator) + Loon + Environment.NewLine;
        }
    }
}
