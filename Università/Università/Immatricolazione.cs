using System;
using System.Collections.Generic;
using System.Text;

namespace Università
{
    public class Immatricolazione
    {
        //proprietà dell'immatricolazione
        public string Matricola { get; }
        public DateTime DataInizio { get; set; }
        public CorsiDiLaurea CorsoDiLaurea { get; set; }
        private bool FuoriCorso { get; set; }
        public int CFUAccumulati { get; set; }

        private static int MatricolaSeed = 610000;

        //Costruttore
        public Immatricolazione(DateTime dataInizio, CorsiDiLaurea corsoDiLaurea)
        {
            Matricola = MatricolaSeed.ToString();
            MatricolaSeed++;
            DataInizio = dataInizio;
            CorsoDiLaurea = corsoDiLaurea;
            FuoriCorso = false;
            CFUAccumulati = 0;
        }
    }
}
