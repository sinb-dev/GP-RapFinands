using System;
using System.Collections.Generic;
namespace Rap_Finands {
    class Konto {
        public string registreringsnr;
        public string kontonr;
        public string ejer;
        public List<Transaktion> transaktioner;
        public Konto() {
            transaktioner = new List<Transaktion>();
            registreringsnr = Program.reginummer; //Sæt registreringsnummer på kontoen!
            kontonr = Program.lavEtKontoNummer(); //Lav et nyt (tilfældigt shh!) kontonummer
        }
        
    }
}