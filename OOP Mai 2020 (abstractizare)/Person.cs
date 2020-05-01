using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Mai_2020__abstractizare_
{
    class Person : ReguliValidare
    {
        public string Nume;
        public string Prenume;
        public string CNP;
        public short Varsta;

        private char[] CharsCNP;
        static bool BoolUnu, BoolDoi, BoolTrei;

        public override bool NullOrEmpty()
        {
            if ( String.IsNullOrEmpty(Nume) || String.IsNullOrEmpty(Prenume) )
            {
                Console.WriteLine("Numele sau prenumele NU sunt corecte pentru obiectul: " + this);
                BoolUnu = false;
                return BoolUnu;
            } else
            {
                Console.WriteLine("Numele sau prenumele sunt corecte pentru obiectul cu numele: " + this.Nume);
                BoolUnu = true;
                return BoolUnu;
            }
        }

        public override bool NumarInString()
        {
            BoolDoi = !string.IsNullOrEmpty(this.CNP);
            if ( BoolDoi )
            {
                this.CharsCNP = this.CNP.ToCharArray();
                foreach (char a in this.CharsCNP)
                {
                if ( !char.IsDigit(a) )
                    {
                        Console.WriteLine("CNP NU este corect (Contine caractere ne-numerice)");
                        BoolDoi = false;
                        break;
                    }
                }
                if ( BoolDoi ) Console.WriteLine("CNP este corect si este format doar din numere ");
            }
            this.CharsCNP = null;
            return BoolDoi;
        }

        public override bool VarstaInInterval()
        {
            switch ( this.Varsta )
            {
                case short x when (x > 9 && x < 121):
                    Console.WriteLine("Varsta este in intervalul 10 - 120");
                    BoolTrei = true;
                    return BoolTrei;
                default:
                    Console.WriteLine("Varsta NU este in intervalul 10 - 120");
                    BoolTrei = false;
                    return BoolTrei;
            }
        }

        public override void MesajConfirmare ()
        {
            if ( BoolUnu && BoolDoi && BoolTrei )
            {
                Console.WriteLine($"Date CORECTE ale Persoanei: { this.Nume }, { this.Prenume }, { this.Varsta } ani, { this.CNP } ");
                Console.WriteLine("-------------------------------------------------------------------------------------");
            } else
            {
                Console.WriteLine($"Date INCORECTE ale Persoanei: { this.Nume }, { this.Prenume }, { this.Varsta } ani, { this.CNP } ");
                Console.WriteLine("------------------------------------------------------------------------------");
            }
        }
    }

    class ListaPersoane : PersonListProcessor
    {
        public ListaPersoane(Person[] ListaPers) : base(ListaPers) { 
        }
    }
}
