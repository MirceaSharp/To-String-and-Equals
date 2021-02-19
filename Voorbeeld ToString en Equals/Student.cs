using System;

namespace Voorbeeld_ToString_en_Equals
{
    class Student : Gebruiker
    {
        private bool _studietoelage;

        public bool Studietoelage
        {
            get { return _studietoelage; }
            set { _studietoelage = value; }
        }

        public Student(char type, int nummer, string voornaam, string familienaam, bool studietoelage)
            : base(type, nummer, voornaam, familienaam)
        {
            this.Studietoelage = studietoelage;
        }

        public override string ToonAlles(string seperator)
        {
            if (Studietoelage)
            {
                return base.ToonAlles(seperator) + "(Studietoelage)" + Environment.NewLine;
            }
            else
            {
                return base.ToonAlles(seperator) + Environment.NewLine;
            }
        }

    }
}
