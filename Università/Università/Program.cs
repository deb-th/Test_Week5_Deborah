using System;
using System.Collections.Generic;

namespace Università
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creazione lista corsi
            Corso corso1 = new Corso("Statistica", 6);
            Corso corso2 = new Corso("Analisi Matematica", 9);

            List<Corso> listaCorsi = new List<Corso> { corso1, corso2 };

            //Creazione Corsi di Laurea
            CorsiDiLaurea corsoLaurea = new CorsiDiLaurea(CorsiDiLaurea.Titolo.Fisica, 3, 180, listaCorsi);

            //Creazione Lista Esami dello studente
            Esame esame1 = new Esame(corso1);
            Esame esame2 = new Esame(corso1);

            List<Esame> listaEsami = new List<Esame> { esame1, esame2 };

            //Creazione Studente al momento dell'immatricolazione
            Studente studente = new Studente("Deborah", "Tucci", 1994, DateTime.Now, corsoLaurea, listaEsami);

            //Notificare l'esame superato
            Studente.EsamePassato(studente, esame2);
        }
    }
}
