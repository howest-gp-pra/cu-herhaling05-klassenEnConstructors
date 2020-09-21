using System;
using System.Collections.Generic;
using System.Text;

namespace Pra.HerhalingKlassenConstructors.CORE
{
    // NIET VERGETEN: je klassen publiek maken !
    public class PersoonMetVelden
    {
        // we werken hier met velden, nog NIET met properties
        // ter herinnering : velden zijn eigenlijk niets meer dan variabelen die je publiek toegangkelijk maakt
        // ter herinnering : gebruik je velden, schrijf die dan met een kleine letter

        //=================================
        // STAP 1  : zonder contstructor
        //=================================

        public string naam;
        public string voornaam;
        public DateTime geboortedatum;
        public char geslacht;  // afspraak : M = man, V = vrouw, O = onbekend

        //t.b.v. stap 4 
        private string privaatje;

        //=================================
        // EINDE STAP 1 
        //============================================================
        // STAP 2  : argumentloze contstructor (= default constructor)
        //============================================================

        public PersoonMetVelden()
        {

            // vergeet voorlopig even dat onderstaande instructie hier staat
            // we hebben deze nodig voor STAP 4
            // deze variabele wordt verder nergens gebruikt
            privaatje = DateTime.Now.ToShortDateString();
        }

        // als dit je enige constructor is (dus zonder argumenten en zonder code) dan kan je hem evengoed NIET maken
        // impliciet is deze immers altijd aanwezig

        //=================================
        // EINDE STAP 2 
        //============================================================
        // STAP 3  : contstructor met 2 argumenten
        //============================================================
        // we maken een tweede constructor aan (de eerste, argumentloze, laten we staan)
        // deze techniek wordt OVERLADEN genoemd en kennen we van onze methoden (zie cursus PRB)
        // je kan een contructor meerdere keren overladen, zolang het aantal argumenten maar verschillend is
        // deze versie verwacht de naam en de voornaam

        public PersoonMetVelden(string naam, string voornaam)
        {
            // probleem is hier dat het argument met een kleine letter geschreven wordt,
            // terwijl het veld dat we wensen te bruiken identiek geschreven is.
            // we lossen dit op door naar het veld te verwijzen met this.

            this.naam = naam;
            this.voornaam = voornaam;
        }

        //=================================
        // EINDE STAP 3 
        //============================================================
        // STAP 4  : constructor met 4 argumenten
        //============================================================
        // we maken nu een derde constructor aan met 4 argumenten
        // VOORALEER WE DIT DOEN VOEGEN WE BOVENAAN NOG EEN EXTRA VELD TOE : het veld privaatje (zie code bovenaan)
        // je hebt er op gelet dat deze variabele een waarde krijgt in de argumentloze constructor
        // willen we hebben dat deze code ook wordt uitgevoerd bij gebruik van een andere constructor,
        // dan moeten we deze uitbreiden met   :this()  .  Dit heet constructor-chaining
        public PersoonMetVelden(string naam, string voornaam, DateTime geboortedatum, char geslacht) : this()
        {
            this.naam = naam;
            this.voornaam = voornaam;
            this.geboortedatum = geboortedatum;
            this.geslacht = geslacht;
        }

        // deze constructor chaining moeten we eigenlijk ook bij onze constructor met 2 argumenten implementeren
        // zodat ook hier de instructie uit de argumentloze contructor uitgevoerd worden

    }
}
