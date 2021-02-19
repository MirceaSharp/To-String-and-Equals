using System;

namespace Voorbeeld_ToString_en_Equals
{
    class Gebruiker
    {
        //eigenschappen
        private char _type;
        private int _nummer;
        private string _voornaam;
        private string _familienaam;

        ////default constructor
        //protected Gebruiker() : this('G', 0, "", ""){}

        public Gebruiker(string voornaam, string familienaam) : this('G', 0, voornaam, familienaam) { }

        public Gebruiker(int nummer, string voornaam, string familienaam) : this('G', nummer, voornaam, familienaam) { }

        public Gebruiker(char type, int nummer, string voornaam, string familienaam)
        {
            this.Type = type;
            this.Nummer = nummer;
            this.Voornaam = voornaam;
            this.Familienaam = familienaam;
        }

        public void Wissen()
        {
            this.Type = 'G';
            this.Nummer = 0;
            this.Voornaam = "";
            this.Familienaam = "";
        }

        public string VolledigeNaam
        {
            get { return this.Voornaam + " " + this.Familienaam; }
        }

        public override string ToString()
        {
            string uitvoer = ToonAlles(Environment.NewLine);
            return uitvoer;
        }

        public virtual string ToonAlles(string seperator)
        {
            string uitvoer = Type + seperator
                                + Nummer.ToString() + seperator
                                + Voornaam + seperator
                                + Familienaam + Environment.NewLine;
            return uitvoer;
        }

        public override bool Equals(object obj)
        {
            // Als het object null is -> return false.

            if (obj == null)
            {
                return false;
            }


            //Als de types niet hetzelfde zijn -> return false.
            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            Gebruiker g = (Gebruiker)obj;
            // Als de properties gelijk zijn -> return true.

            return (this.Nummer == g.Nummer);
        }


        //properties
        public char Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Nummer
        {
            get { return _nummer; }
            set { _nummer = value; }
        }

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value; }
        }
    }
}
