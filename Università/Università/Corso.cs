using System;
using System.Collections.Generic;
using System.Text;

namespace Università
{
    public class Corso
    {
        //proprietà del singolo corso
        public string Name { get; set;  }
        public int CFU { get; set; }

        //Costruttore
        public Corso (string name, int cfu)
        {
            Name = name;
            CFU = cfu;
        }
    }
}
