using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Klassenarbeitgenerator.Data
{
    class Aufgabe
    {
        SQLCommands sqlCommander = new SQLCommands();

        public Aufgabe(string name, int schwierigkeitsgrad, string thema, string fach, string aufgabentext, DateTime erstelldatum)
        {
            this.name = name;
            this.schwierigkeitsgrad = schwierigkeitsgrad;
            this.thema = thema;
            this.fach = fach;
            this.aufgabentext = aufgabentext;
            this.erstelldatum = erstelldatum;
        }

        public Aufgabe(string name, int schwierigkeitsgrad, string thema, string fach, string aufgabentext, DateTime erstelldatum, string bild)
        {
            this.name = name;
            this.schwierigkeitsgrad = schwierigkeitsgrad;
            this.thema = thema;
            this.fach = fach;
            this.aufgabentext = aufgabentext;
            this.bild = Image.FromFile(bild);
            this.erstelldatum = erstelldatum;
        }


        private string name;
        private int schwierigkeitsgrad;
        private string thema;
        private string fach;
        private string aufgabentext;
        private Image bild;
        private DateTime erstelldatum;


        public void AufgabeErstellen()
        {
            sqlCommander.AddTaskToDatabase(name, schwierigkeitsgrad, thema, fach, aufgabentext, erstelldatum, bild);
        }
    }
}
