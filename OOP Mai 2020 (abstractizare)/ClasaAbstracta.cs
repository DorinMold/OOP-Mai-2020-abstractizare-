using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Mai_2020__abstractizare_
{
    abstract class ReguliValidare
    {
        public abstract bool NullOrEmpty();
        public abstract bool NumarInString();
        public abstract bool VarstaInInterval();
        public abstract void MesajConfirmare();

    }
    abstract class PersonListProcessor
    {
        public PersonListProcessor(Person[] ListaPersoane)
        {
            foreach ( Person p in ListaPersoane )
            {
                p.NullOrEmpty();
                p.NumarInString();
                p.VarstaInInterval();
                p.MesajConfirmare();
            }
        }


    }
}
