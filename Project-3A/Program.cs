﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Project_3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable sirketler = new Hashtable();
            SirketleriOku(sirketler);
            Tree elemanlar = new Tree();

            System.IO.StreamReader file = new System.IO.StreamReader(Environment.CurrentDirectory + @"\eleman.txt");
            string line;
            Eleman e=null;
            while ((line = file.ReadLine()) != null)
            {
                if (line.StartsWith("KİŞİ"))
                {
                    e = new Eleman();
              
                    int i = 5;
                    e.KisiAdi = line[i].ToString();
                    while (line[++i] != '\t')
                        e.KisiAdi += line[i];

                    i = line.IndexOf("Eleman Adresi ") + 13;
                    e.ElemanAdresi = line[++i].ToString();
                    while (line[++i] != '\t')
                        e.ElemanAdresi += line[i];

                    i = line.IndexOf("Telefon ") + 7;
                    e.Telefon = line[++i].ToString();
                    while (line[++i] != '\t')
                        e.Telefon += line[i];

                    e.Uyruk = line[++i].ToString();
                    while (line[++i] != '\t')
                        e.Uyruk += line[i];

                    i = line.IndexOf("E-Posta") + 7;
                    e.EPosta = line[++i].ToString();
                    while (line[++i] != '\t')
                        e.EPosta += line[i];

                    e.DogumYeri = line[++i].ToString();
                    while (line[++i] != '\t')
                        e.DogumYeri += line[i];

                    e.DogumTarihi= line[++i].ToString();
                    while (line[++i] != '\t')
                        e.DogumTarihi += line[i];

                    e.MedeniDurum = line[++i].ToString();
                    while (line[++i] != '\t')
                        e.MedeniDurum += line[i];

                    e.YabanciDil = line[++i].ToString();
                    while (line[++i] != '\t')
                        e.YabanciDil += line[i];

                    e.IlgiAlanlari = line[++i].ToString();
                    while (line[++i] != '\t')
                        e.IlgiAlanlari += line[i];

                    e.ReferansOlanKisiler  = line[++i].ToString();
                    while (++i != line.Length)
                        e.ReferansOlanKisiler += line[i];

                }
                else if (line.StartsWith("OKUL"))
                { }
                else ;
                Console.WriteLine(e.KisiAdi);
            }
            Console.Read();
        }

        private static void SirketleriOku(Hashtable sirketler)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(Environment.CurrentDirectory + @"\sirket.txt");
            string line;
            Sirket s;
            while ((line = file.ReadLine()) != null)
            {
                s = new Sirket();

                int i = 11;
                s.SirketAdi = line[i].ToString();
                while (line[++i] != '\t')
                    s.SirketAdi += line[i];

                i = line.IndexOf("Tam Adresi ") + 10;
                s.TamAdresi = line[++i].ToString();
                while (line[++i] != '\t')
                    s.TamAdresi += line[i];

                i = line.IndexOf("Telefon ") + 7;
                s.TelefonNo = line[++i].ToString();
                while (line[++i] != '\t')
                    s.TelefonNo += line[i];

                i = line.IndexOf("Faks") + 4;
                s.Faks = line[++i].ToString();
                while (line[++i] != '\t')
                    s.Faks += line[i];

                i = line.IndexOf("E-Posta") + 7;
                s.EPosta = line[++i].ToString();
                while (++i != line.Length)
                    s.EPosta += line[i];

                sirketler[s.SirketAdi] = s;
                //Console.WriteLine(s.ToString());

            }

            file.Close();
        }
    }
}
