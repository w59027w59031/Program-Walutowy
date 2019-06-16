﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;

namespace Program_Walutowy
{
    public partial class Form2 : Form
    {
        public class waluty
        {
            public string nazwa_waluty = "";
            public float przelicznik;
            public string kod_waluty = "";
            public float kurs_kupna;
            public float kurs_sprzedazy;
        }
        waluty[] wwaluty = new waluty[0];
        public class LUZER
        {
            public string id;
            public string email;
            public string login;
            public string haslo;
            public int pln;
            public DateTime data_rejestracji;
            public DateTime data_ostatniego_log;
        }

        public LUZER JA;

        public Form2()
        {
            InitializeComponent();
            JA = new LUZER();
            string url = "https://www.nbp.pl/kursy/xml/c114z190613.xml";
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(url);
            string XMLStr = "";
            using (var wc = new WebClient())
            {
                XMLStr = wc.DownloadString(url);
            }
            int licznik_pozycji = 0;
            int licznik_p_poz = 0;
            foreach (string str1 in XMLStr.Split(new string[1] { "<pozycja>" }, StringSplitOptions.None))
            {
                foreach (string str2 in str1.Split(new string[1] { "</pozycja>" }, StringSplitOptions.None))
                {
                    waluty[] wwaluty_tmp = new waluty[wwaluty.Length];
                    /*for (int i = 0; i < wwaluty.Length-1; i++) {
                        wwaluty_tmp[i] = new waluty();
                        wwaluty_tmp[i].kod_wal = "";
                        wwaluty_tmp[i].kurs_kup = 0;
                        wwaluty_tmp[i].Kurs_sprz = 0;
                        wwaluty_tmp[i].nazwa_wal = "";
                        wwaluty_tmp[i].przelicznik = 0;
                        wwaluty_tmp[i] = wwaluty[i];
                    }*/
                    wwaluty_tmp = wwaluty;
                    wwaluty = new waluty[wwaluty_tmp.Length+1];
                    for (int i = 0; i < wwaluty.Length-1; i++)
                    {
                        wwaluty[i] = new waluty();
                        wwaluty[i].kod_waluty = "";
                        wwaluty[i].kurs_kupna = 0;
                        wwaluty[i].kurs_sprzedazy = 0;
                        wwaluty[i].nazwa_waluty = "";
                        wwaluty[i].przelicznik = 0;
                        wwaluty[i] = wwaluty_tmp[i];
                    }
                    wwaluty[wwaluty.Length - 1] = new waluty();
                    if (licznik_pozycji > 0)
                    {
                        foreach (string pstr1 in str2.Split(new string[1] { "<nazwa_waluty>" }, StringSplitOptions.None))
                        {
                            if (licznik_p_poz > 0)
                            {
                                wwaluty[wwaluty.Length - 1].nazwa_waluty = pstr1.Split(new string[1] { "</nazwa_waluty>" }, StringSplitOptions.None)[0];
                            }
                            licznik_p_poz++;
                        }
                        licznik_p_poz = 0;
                        foreach (string pstr1 in str2.Split(new string[1] { "<przelicznik>" }, StringSplitOptions.None))
                        {
                            if (licznik_p_poz > 0)
                            {
                                wwaluty[wwaluty.Length - 1].przelicznik = float.Parse(pstr1.Split(new string[1] { "</przelicznik>" }, StringSplitOptions.None)[0]);
                            }
                            licznik_p_poz++;
                        }
                        licznik_p_poz = 0;
                        foreach (string pstr1 in str2.Split(new string[1] { "<kod_waluty>" }, StringSplitOptions.None))
                        {
                            if (licznik_p_poz > 0)
                            {
                                wwaluty[wwaluty.Length - 1].kod_waluty = pstr1.Split(new string[1] { "</kod_waluty>" }, StringSplitOptions.None)[0];
                            }
                            licznik_p_poz++;
                        }
                        licznik_p_poz = 0;
                        foreach (string pstr1 in str2.Split(new string[1] { "<kurs_kupna>" }, StringSplitOptions.None))
                        {
                            if (licznik_p_poz > 0)
                            {
                                wwaluty[wwaluty.Length - 1].kurs_kupna = float.Parse(pstr1.Split(new string[1] { "</kurs_kupna>" }, StringSplitOptions.None)[0]);
                            }
                            licznik_p_poz++;
                        }
                        licznik_p_poz = 0;
                        foreach (string pstr1 in str2.Split(new string[1] { "<kurs_sprzedazy>" }, StringSplitOptions.None))
                        {
                            if (licznik_p_poz > 0)
                            {
                                wwaluty[wwaluty.Length - 1].kurs_sprzedazy = float.Parse(pstr1.Split(new string[1] { "</kurs_sprzedazy>" }, StringSplitOptions.None)[0]);
                            }
                            licznik_p_poz++;
                        }
                    }
                }
                licznik_pozycji++;
            }
            for(int i=1;i<wwaluty.Length-1;i++)
            {
                MessageBox.Show(wwaluty[i].nazwa_waluty+@"
"+wwaluty[i].przelicznik.ToString() + @"
" + wwaluty[i].kod_waluty + @"
" + wwaluty[i].kurs_kupna.ToString() + @"
" + wwaluty[i].kurs_sprzedazy.ToString());
            }


            /*
            xmlDocument.LoadXml(XMLStr);
            foreach (XmlNode item in xmlDocument.ChildNodes)
            {
                string str1 = GetChildren(item, "tabela_kursow", "tabela_kursow");
                if (str1 != null && str1 != "" && str1.Length > 0)
                {
                    XmlDocument docdoc = new XmlDocument();
                    docdoc.LoadXml(item.InnerXml);
                    MessageBox.Show(docdoc.InnerXml);
                    foreach (XmlNode item2 in docdoc.ChildNodes)
                    {
                        string str2 = GetChildren(item2,"pozycja", "nazwa_waluty");
                        if (str2 != null && str2 != "" && str2.Length > 0)
                        {
                            MessageBox.Show(str2);
                        }
                    }
                }
            }*/
        }

        private string GetChildren(XmlNode node, string element, string par)
        {
            if (node.LocalName == element)
            {
                foreach (string atrybut1 in node.InnerXml.Split(new string[1] { "<" + par + ">" }, StringSplitOptions.None))
                {
                    string atrybut2 = atrybut1.Split(new string[1] { "</" + par + ">" }, StringSplitOptions.None)[0];
                    if (atrybut2 != null && atrybut2 != "" && atrybut2.Length > 0)
                    {
                        return atrybut2;
                    }
                }
            }
            return "";
        }

        public void SHOWWTFWTF()
        {

            MessageBox.Show("Ja: " + JA.login);
        }
    }
}