using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pra.HerhalingKlassenConstructors.CORE;

namespace Pra.HerhalingKlassenConstructors.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnPMV1_Click(object sender, RoutedEventArgs e)
        {
            // BEKIJK DE KLASSE PERSOONMETVELDEN : deze code gebruikt STAP 1, situatie waarbij geen constructor bestaat
            // ps : in vorige voorbeeld (herhaling.klassen) hebben we uitsluitend met deze situatie gewerkt

            lstDisplay.Items.Clear();

            PersoonMetVelden persoon = new PersoonMetVelden();
            persoon.naam = "Piraat";
            persoon.voornaam = "Piet";
            persoon.geboortedatum = DateTime.Parse("1987-05-30");
            persoon.geslacht = 'M';
            lstDisplay.Items.Add(persoon.voornaam + " " + persoon.naam + " (geslacht = " + persoon.geslacht + ")");

            persoon = new PersoonMetVelden();
            persoon.naam = "Taar";
            persoon.voornaam = "Guy";
            persoon.geboortedatum = DateTime.Parse("1961-11-03");
            persoon.geslacht = 'M';
            lstDisplay.Items.Add(persoon.voornaam + " " + persoon.naam + " (geslacht = " + persoon.geslacht + ")");

            persoon = new PersoonMetVelden();
            persoon.naam = "Ba";
            persoon.voornaam = "Sam";
            persoon.geboortedatum = DateTime.Parse("1012-01-03");
            persoon.geslacht = 'X';
            lstDisplay.Items.Add($"{persoon.voornaam} {persoon.naam} (geslacht = {persoon.geslacht} )");  // alternatieve schrijfwijze

        }
        private void BtnPMV2_Click(object sender, RoutedEventArgs e)
        {
            // BEKIJK DE KLASSE PERSOONMETVELDEN : deze code gebruikt STAP 2, situatie waarbij 
            // een lege constructor gebruikt wordt.  Dit is een constructor die geen argumenten ontvangt
            // en die geen code bevat.
            // Is dit de enige constructor in je klasse dan kan je die evengoed weglaten.
            // de code hieronder is dus identiek aan de eventhandler hierboven

            lstDisplay.Items.Clear();

            PersoonMetVelden persoon = new PersoonMetVelden();
            persoon.naam = "Piraat";
            persoon.voornaam = "Piet";
            persoon.geboortedatum = DateTime.Parse("1987-05-30");
            persoon.geslacht = 'M';
            lstDisplay.Items.Add(persoon.voornaam + " " + persoon.naam + " (geslacht = " + persoon.geslacht + ")");

            persoon = new PersoonMetVelden();
            persoon.naam = "Taar";
            persoon.voornaam = "Guy";
            persoon.geboortedatum = DateTime.Parse("1961-11-03");
            persoon.geslacht = 'M';
            lstDisplay.Items.Add(persoon.voornaam + " " + persoon.naam + " (geslacht = " + persoon.geslacht + ")");

            persoon = new PersoonMetVelden();
            persoon.naam = "Ba";
            persoon.voornaam = "Sam";
            persoon.geboortedatum = DateTime.Parse("1012-01-03");
            persoon.geslacht = 'X';
            lstDisplay.Items.Add($"{persoon.voornaam} {persoon.naam} (geslacht = {persoon.geslacht} )");  // alternatieve schrijfwijze

        }

        private void BtnPMV3_Click(object sender, RoutedEventArgs e)
        {
            // BEKIJK DE KLASSE PERSOONMETVELDEN : deze code gebruikt STAP 3, situatie waarbij 
            // een contructor werd bijgemaakt die nu 2 argumenten gebruikt.
            // Wanneer we nu een object aanmaken hebben we nu de mogelijkheid om te kiezen welke contructor 
            // we willen gebruiken.
            // in de code hieronder gaan we het eerste object aanmaken m.b.v. de argumentloze contructor, 
            // het tweede en derde object m.b.v. de constructor die 2 argumenten verwacht

            lstDisplay.Items.Clear();

            PersoonMetVelden persoon = new PersoonMetVelden();
            persoon.naam = "Piraat";
            persoon.voornaam = "Piet";
            persoon.geboortedatum = DateTime.Parse("1987-05-30");
            persoon.geslacht = 'M';
            lstDisplay.Items.Add(persoon.voornaam + " " + persoon.naam + " (geslacht = " + persoon.geslacht + ")");

            persoon = new PersoonMetVelden("Taar", "Guy");
            persoon.geboortedatum = DateTime.Parse("1961-11-03");
            persoon.geslacht = 'M';
            lstDisplay.Items.Add(persoon.voornaam + " " + persoon.naam + " (geslacht = " + persoon.geslacht + ")");

            persoon = new PersoonMetVelden("Ba", "Sam");
            persoon.geboortedatum = DateTime.Parse("1012-01-03");
            persoon.geslacht = 'X';
            lstDisplay.Items.Add($"{persoon.voornaam} {persoon.naam} (geslacht = {persoon.geslacht} )");  // alternatieve schrijfwijze



        }

        private void BtnPMV4_Click(object sender, RoutedEventArgs e)
        {
            // BEKIJK DE KLASSE PERSOONMETVELDEN : deze code gebruikt STAP 4, situatie waarbij 
            // een contructor werd bijgemaakt die nu 4 argumenten gebruikt.
            // Wanneer we nu een object aanmaken hebben we keuze uit 3 constructors
            // in de code hieronder gaan we het eerste object aanmaken m.b.v. de argumentloze contructor, 
            // het tweede m.b.v. de constructor die 2 argumenten verwacht en
            // het derde m.b.v. de constructor die 3 argumenten verwacht
            // bekijk in je klasse zelf ook de opmerking rond constructor-chaining

            lstDisplay.Items.Clear();

            PersoonMetVelden persoon = new PersoonMetVelden();
            persoon.naam = "Piraat";
            persoon.voornaam = "Piet";
            persoon.geboortedatum = DateTime.Parse("1987-05-30");
            persoon.geslacht = 'M';
            lstDisplay.Items.Add(persoon.voornaam + " " + persoon.naam + " (geslacht = " + persoon.geslacht + ")");

            persoon = new PersoonMetVelden("Taar", "Guy");
            persoon.geboortedatum = DateTime.Parse("1961-11-03");
            persoon.geslacht = 'M';
            lstDisplay.Items.Add(persoon.voornaam + " " + persoon.naam + " (geslacht = " + persoon.geslacht + ")");

            persoon = new PersoonMetVelden("Ba", "Sam", DateTime.Parse("1012-01-03"), 'X');
            lstDisplay.Items.Add($"{persoon.voornaam} {persoon.naam} (geslacht = {persoon.geslacht} )");  // alternatieve schrijfwijze

            // bekijk de hoeveelheid code die je nodig hebt om het 1°,het 2° en het 3° object aan te maken
            // je merkt dat een "uitgebreide" constructor je achteraf toch wel wat typewerk kan besparen.
            // maar dat is uiteraard niet de enige bedoeling van constructors.
            // we komen hier in een volgend voorbeeld nog op terug
        }
    }
}
