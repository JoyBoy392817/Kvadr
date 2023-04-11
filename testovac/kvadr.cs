using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testovac
{
    internal class Kvadr
    {
        public double StranaA { get; set; }
        public double StranaB { get; set; }
        public double StranaC { get; set; }
        public Kvadr(double a, double b, double c)
        {
            StranaA = a;
            StranaB = b;
            StranaC = c;
        }
        public double Objem()
        {
            return (StranaC * StranaB * StranaA);
        }
        public double Povrch()
        {
            return 2 * (StranaA * StranaB + StranaA * StranaC + StranaB * StranaC);
        }
        public double Uhlopricky()
        {
            return Math.Sqrt(Math.Pow(StranaA, 2)+Math.Pow(StranaB, 2)+Math.Pow(StranaC, 2));
        }
        public double Uhlop
        {
            return 
        }
        //public double Uhlopricak()
        //{
        //    //to do 
        //}
    }
}
