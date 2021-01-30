using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Klasse_Fahrrad_Anwendereingabe
{
    class Fahrrad
    {
    

        private double Rahmengroeße;
        private double Laufradgroeße;
        private string Fahrradtyp;
        private double Preis;
        private int Baujahr;
        private double Verkaufspreis;
        private int Alter;

        public Fahrrad(double rahmen, double laufrad, string typ, double preis, int baujahr, double verkaufspreis, int alter)
        {
            this.Rahmengroeße = rahmen;
            this.Laufradgroeße = laufrad;
            this.Fahrradtyp = typ;
            this.Preis = preis;
            this.Baujahr = baujahr;
            this.Verkaufspreis = verkaufspreis;
            this.Alter = alter;
        }

        public virtual void memberAusgabe()
        {
            Console.WriteLine("Rahmengöße: " + this.Rahmengroeße);
            Console.WriteLine("Laufradgröße: " + this.Laufradgroeße);
            Console.WriteLine("Fahrradtyp: " + this.Fahrradtyp);
            Console.WriteLine("Preis: " + this.Preis);
            Console.WriteLine("Baujahr: " + this.Baujahr);
            Console.WriteLine("Alter: " + this.Alter);
            Console.WriteLine("Verkaufspreis: " + this.Verkaufspreis);
        }
        
        
        //Speichert Anwendereingaben in das Objekt
        public void setRahmengroeße(double rahmen)
        {
            this.Rahmengroeße = rahmen;
        }

        public void setLaufradgroeße(double laufrad)
        {
            this.Laufradgroeße = laufrad;
        }

        public void setFahrradtyp(string typ)
        {
            this.Fahrradtyp = typ;
        }

        public void setPreis(double preis)
        {
            this.Preis = preis;
        }

        public void setBaujahr(int baujahr)
        {
            this.Baujahr = baujahr;
        }




        //berechnet Alter und Verkaufspreis des Objekts
        public int AlterBerechnen()
        {
            int alter = (2020 - this.Baujahr);
            return alter;
        }
        public double VerkaufspreisBerechnen()
        {
            
            double verkaufspreis = (this.Preis / this.Alter);
            return verkaufspreis;
        }


    }
    class Trailbike: Fahrrad
    {
        private string Stoßdaempfer;
        public Trailbike(double rahmen, double laufrad, string typ, double preis, int baujahr, double verkaufspreis, int alter, string daempfer) :
            base(rahmen, laufrad, typ, preis, baujahr, verkaufspreis, alter)
        {
            this.Stoßdaempfer = daempfer;
        }
        public override void memberAusgabe()
        {
            base.memberAusgabe();
            Console.WriteLine("Dämpfer: " + this.Stoßdaempfer);
        }

        public void setStoßdaempfer(string daempfer)
        {
            this.Stoßdaempfer = daempfer;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Fahrrad> Fahrraeder = new List<Fahrrad>();
            int zaehler = 0;
            char fortfahren = 'j';

            while (fortfahren == 'j')
            {



                Fahrraeder.Add(new Fahrrad());


                Console.Write("Bitte geben Sie die Rahmengröße Ihres Fahrrads an: ");
                Fahrraeder[zaehler].setRahmengroeße(double.Parse(Console.ReadLine()));
                
                Console.Write("Bitte geben Sie die Laufradgröße Ihres Fahrrads an: ");
                Fahrraeder[zaehler].setLaufradgroeße(double.Parse(Console.ReadLine()));
                
                Console.Write("Bitte geben Sie die Fahrradtyp Ihres Fahrrads an: ");
                Fahrraeder[zaehler].setFahrradtyp(Console.ReadLine());
                
                Console.Write("Bitte geben Sie den Preis Ihres Fahrrads an: ");
                Fahrraeder[zaehler].setPreis(double.Parse(Console.ReadLine()));
                
                Console.Write("Bitte geben Sie das Baujahr Ihres Fahrrads an: ");
                Fahrraeder[zaehler].setBaujahr(int.Parse(Console.ReadLine()));

                Fahrraeder[zaehler].Alter = Fahrraeder[zaehler].AlterBerechnen();
                Fahrraeder[zaehler].Verkaufspreis = Fahrraeder[zaehler].VerkaufspreisBerechnen();

                Fahrraeder[zaehler].memberAusgabe();

                Console.WriteLine(zaehler + "Platz vergeben");
                zaehler++;
                
                Console.WriteLine("Möchten Sie ein weiteres Objekt hinzufügen?(j/n)");
                fortfahren = char.Parse(Console.ReadLine());

            }
            
            foreach (Fahrrad Fahrradliste in Fahrraeder)
            {
                Fahrradliste.memberAusgabe();
            }



        }
    }
}
