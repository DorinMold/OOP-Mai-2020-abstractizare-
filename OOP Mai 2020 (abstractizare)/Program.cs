using System;

namespace OOP_Mai_2020__abstractizare_
{
    class Program
    {
        public static Person[] ListaPers = { new Person { Nume = "NumeUnu", Prenume = "PrenumeUnu", CNP = "1819945243917", Varsta = 10 },
                                      new Person { Nume = "NumeDoi", Prenume = "PrenumeDoi", CNP = "2014084253929", Varsta = 20 },
                                      new Person { Nume = "NumeTrei", Prenume = "PrenumeTrei", CNP = "1513387a43924", Varsta = 5 },
                                      new Person { Nume = "NumePatru", Prenume = "PrenumePatru", CNP = "10134385543842", Varsta = 40 }};
        static void Main(string[] args)
        {
            ListaPersoane lista = new ListaPersoane(ListaPers);
        }
    }
}
