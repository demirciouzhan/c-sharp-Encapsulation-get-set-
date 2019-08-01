using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emlak
{
    class emlk
    {
        private string semt;
        private string renk;
        private int odasayi;
        private int katno;
        private double alan;

        public string semti
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
        public string RENGİ
        {
            get { return renk; }
            set { renk = value.ToLower();}
        }
        public int odasayisi
        {
            get { return odasayi; }
            set { odasayi = Math.Abs(value); }
        }
        public int katnosu
        {
            get { return katno; }
            set { katno = Math.Abs(value); }
        }
        public double alanı
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }


    }
}
