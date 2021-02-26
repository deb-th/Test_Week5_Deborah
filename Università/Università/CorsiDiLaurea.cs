using System;
using System.Collections.Generic;
using System.Text;

namespace Università
{
    public class CorsiDiLaurea
    {
        //proprietà di Corsi di Laurea
        public Titolo Nome { get; set; }
        public int AnniDiCorso { get; set; }
        public int CFU { get; set; }
        public List<Corso> Corsi { get; }

        //definizione del tipo Enum Titolo per il nome del corso di Laurea
        public enum Titolo
        {
            Matematica,
            Fisica,
            Informatica,
            Ingegneria,
            Lettere
        }

        //Costruttore
        public CorsiDiLaurea (Titolo name, int anni, int cfu, List<Corso> corsi)
        {
            Nome = name;
            AnniDiCorso = anni;
            CFU = cfu;
            Corsi = corsi;
        }
    }
}
