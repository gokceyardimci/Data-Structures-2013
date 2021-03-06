﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._2
{
    class Ogrenci : IComparable <Ogrenci>
    {
        public Ogrenci()
        { }
        public Ogrenci(Ogrenci o)
        {
            ad = o.ad;
            soyad = o.soyad;
            degerlendirmeNotu = o.degerlendirmeNotu;


        }
        public Ogrenci(string a, string s, int not)
        {
            ad = a;
            soyad = s;
            degerlendirmeNotu = not;
        }
        private string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        private string soyad;

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        private int degerlendirmeNotu;

        public int DegerlendirmeNotu
        {
            get { return degerlendirmeNotu; }
            set { degerlendirmeNotu = value; }
        }
        public override string  ToString()
        {
            return ad + " " + soyad + " " + degerlendirmeNotu;
        }

        public int CompareTo(Ogrenci b)
        {
            return this.degerlendirmeNotu.CompareTo(b.DegerlendirmeNotu);
        }

    }
}
