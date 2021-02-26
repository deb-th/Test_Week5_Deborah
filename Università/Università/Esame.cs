using System;
using System.Collections.Generic;
using System.Text;

namespace Università
{
    public class Esame
    {
        //proprietà del singolo esame sostenuto dallo studente
        public Corso Corso { get; }
        public bool Passato { get; set; }

        //Costruttore
        public Esame (Corso corso)
        {
            Corso = corso;
            Passato = false;
        }
    }
}
