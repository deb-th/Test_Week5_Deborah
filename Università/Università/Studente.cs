using System;
using System.Collections.Generic;
using System.Text;

namespace Università
{
    public class Studente
    {
        //proprietà dello Studente
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoDiNascita { get; set; }
        public Immatricolazione ImmatricolazioneStudente { get; set; }

        private List<Esame> Esami = new List<Esame>();
        public bool RichiestaLaurea { get; set; }

        //Costruttore
        public Studente(string name, string lastname, int anno, DateTime dataInizio, CorsiDiLaurea corsoLaurea, List<Esame> esami)
        {
            Nome = name;
            Cognome = lastname;
            AnnoDiNascita = anno;
            RichiestaLaurea = false;
            ImmatricolazioneStudente = new Immatricolazione(dataInizio, corsoLaurea);
            Esami = esami;
        }

        //Metodo Esame Passato
        public static void EsamePassato(Studente studente, Esame esame)
        {
            if (studente.Esami.Contains(esame))
            {
                esame.Passato = true;
                studente.ImmatricolazioneStudente.CFUAccumulati += esame.Corso.CFU;
            }
            
            if (studente.ImmatricolazioneStudente.CFUAccumulati >= studente.ImmatricolazioneStudente.CorsoDiLaurea.CFU)
            {
                studente.RichiestaLaurea = true;
            }            
        }      
    }
}
