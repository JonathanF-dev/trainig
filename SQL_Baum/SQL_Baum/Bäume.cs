using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_Baum
{
    class Baum

    {
        private int Nummer;
        private string Art;
        private double Hoehe;

        public Baum(int num, string type, double high)
        {
            num = this.Nummer;
            type = this.Art;
            high = this.Hoehe;
        }

        public void setNummer(int num)
        {
            num = this.Nummer;
        }

        public void setArt(string type)
        {
            type = this.Art;
        }

        public void setHoehe(double high)
        {
            high = this.Hoehe;
        }

        public int getNummer()
        {
            return this.Nummer;
        }

        public string getArt()
        {
            return this.Art;
        }

        public double getHoehe()
        {
            return this.Hoehe;
        }
    }
}
